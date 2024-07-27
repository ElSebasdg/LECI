from cryptography.hazmat.primitives import serialization
from cryptography.hazmat.primitives import padding
import sys


if __name__=='__main__':
    if len(sys.argv) != 4:
        print("cript src dst pubkeyfile")
        exit(-1)

    with open(sys.argv[3], "rb") as key_file:
        pub_key = serialization.load_pem_public_key(
            key_file.read()
        )
    
    fsrc = open(sys.argv[1], "rb")
    with open(sys.argv[2], "wb") as fdst:
       fdst.write(b'')
    fdst = open(sys.argv[2], "ab")

    while true:
        data = fsrc.read(117)
        if not data:
            break
        ciphertext = pub_key.encrypt(
            data,
            padding.PKCS1v15()
        )
        fdst.write(ciphertext)

    fdst.close()
    fsrc.close()
   
