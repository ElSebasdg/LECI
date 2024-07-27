import sys
from cryptography import x509
from datetime import datetime

def certval(certificate):
    now = datetime.now()

    if (now > certificate.not_valid_before) & (now < certificate.not_valid_after):
        return True
    else:
        return False

if __name__ == '__main__':
    if len(sys.argv) != 2:
        print(f'Usage {sys.argv[0]} certificate name')
        exit(-1)

    with open(sys.argv[1], 'rb') as fcert:
        cert = x509.load_pem_x509_certificate(fcert.read())

        if certval(cert):
            print(" ___________________")
            print("< Valid certificate >")
            print(" -------------------")
            print("   \\")
            print("    \\")
            print("        .--.")
            print("       |o_o |")
            print("       |:_/ |")
            print("      //   \\ \\")
            print("     (|     | )")
            print("    /'\\_   _/`\\")
            print("    \\___)=(___/")

        else:
            print(" ___________________")
            print("< Invalid certificate >")
            print(" -------------------")
            print("   \\")
            print("    \\")
            print("        .--.")
            print("       |o_o |")
            print("       |:_/ |")
            print("      //   \\ \\")
            print("     (|     | )")
            print("    /'\\_   _/`\\")
            print("    \\___)=(___/")