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
        
if __name__ == '__main__':
    if len(sys.argv) != 1:
        print(f" _____________________________")
        print(f"< Usage: {sys.argv[0]}>")
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

    objs = os.scandir('/etc/ssl/certs')
    certdict = {}

    for o in objs:
        if fnmatch.fnmatch(o.name, '*.*'):
            abscertname = Path('/etc/ssl/certs') / o.name

            with open(abscertname, 'rb') as fcrt:
                cert = x509.load_pem_x509_certificate(fcrt.read())
                if certval(cert):
                    certdict[cert.subject]=cert
    for k,v in certdict.items():
        print(f'K: {k} =====> V: {v} \n')
