import sys
import os
import fnmatch # fazer filtragem dos nomes dos ficheiros
from pathlib import Path
from cryptography import x509
from datetime import datetime

def certval(certificate):
    now = datetime.now()

    if (now > certificate.not_valid_before) & (now < certificate.not_valid_after):
        return True
    else:
        return False

def certlist(pathcert):
    objs = os.scandir(pathcert)
    certdict = {}

    for o in objs:
        if fnmatch.fnmatch(o.name, '*.*'):
            abscertname = os.getcwd() / Path(pathcert) / o.name
            with open(abscertname, 'rb') as fcrt:
                cert = x509.load_pem_x509_certificate(fcrt.read())
                if certval(cert):
                    certdict[cert.subject] = cert
    return certdict

        
if __name__ == '__main__':
    if len(sys.argv) != 3:
        print(f" _____________________________")
        print(f"< Usage: {sys.argv[0]} <anchorss path> <server pem>>")
        print(f" -----------------------------")
        print("   \\")
        print("    \\")
        print("        .--.")
        print("       |o_o |")
        print("       |:_/ |")
        print("      //   \\ \\")
        print("     (|     | )")
        print("    /'\\_   _/`\\")
        print("    \\___)=(___/")
        sys.exit(-1)
    
    cd = certlist(sys.argv[1])
    certchain = {}


    with open(sys.argv[2], 'rb') as fspem:
        cert = x509.load_pem_x509_certificate(fspem.read())

        certchain[cert.subject] = cert
        issuer = cert.issuer
        subject = cert.subject


        while True:
            if issuer in cd:
                certchain[issuer] = cd[issuer]
                if cd[issuer].issuer ==  cd[issuer].subject:
                    break

                issuer = cd[issuer].issuer
                subject = cd[issuer].subject
            else:
                print("broken chain")
                exit(-1)

        for k,v in certdict.items():
            print(f'K: {k} =====> V: {v} \n')
