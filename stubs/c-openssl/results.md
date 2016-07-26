```
openssl: OpenSSL 1.1.0-pre6-dev
gcc (Ubuntu 5.4.0-6ubuntu1~16.04.1) 5.4.0 20160609

platform: Linux (Ubuntu 16.04)
runner: bashtls
stub: c-openssl
```

```
[c-openssl][ PASS ][VERIFY SUCCESS][ Valid cert ][google.com]
[c-openssl][ PASS ][VERIFY FAILURE][ OS X vulnerability ][www.ssllabs.com]
[c-openssl][ PASS ][VERIFY FAILURE][ Freak              ][www.ssllabs.com]
[c-openssl][ PASS ][VERIFY FAILURE][ Logjam             ][www.ssllabs.com]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports SNI                  ][badssl.com]
[c-openssl][ PASS ][VERIFY FAILURE][ expired                       ][expired.badssl.com]
[c-openssl][ PASS ][VERIFY FAILURE][ wrong host                    ][wrong.host.badssl.com]
[c-openssl][ PASS ][VERIFY FAILURE][ self-signed                   ][self-signed.badssl.com]
[c-openssl][ PASS ][VERIFY SUCCESS][ sha-256                       ][sha256.badssl.com]
[c-openssl][ PASS ][VERIFY SUCCESS][ 1000-sans                     ][1000-sans.badssl.com]
[c-openssl][ FAIL ][VERIFY FAILURE][ 10000-sans (Bad in ten years) ][10000-sans.badssl.com]
[c-openssl][ PASS ][VERIFY FAILURE][ incomplete-chain              ][incomplete-chain.badssl.com]
[c-openssl][ OK?  ][VERIFY SUCCESS][ pinning-test                  ][pinning-test.badssl.com]
[c-openssl][ PASS ][VERIFY FAILURE][ superfish                     ][superfish.badssl.com]
[c-openssl][ PASS ][VERIFY FAILURE][ edellroot                     ][edellroot.badssl.com]
[c-openssl][ PASS ][VERIFY FAILURE][ dsdtestprovider               ][dsdtestprovider.badssl.com]
[c-openssl][ PASS ][VERIFY FAILURE][ disable ca-bundles            ][badssl.com]
[c-openssl][ PASS ][VERIFY FAILURE][ correct cn, wrong san                      ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ expired cert                               ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ sslv2 supported                            ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ sslv3 supported                            ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ supports 'ADH'                             ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ supports 'AECDH'                           ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ supports 'AECDH'                           ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ supports 'DES'                             ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ supports 'ECDSA'                           ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ supports 'insecure' ciphers                ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ supports 'MD5'                             ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ supports 'NULL'                            ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ supports 'RC4'                             ][localhost]
[c-openssl][ PASS ][VERIFY FAILURE][ wrong hostname                             ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ correct cert                               ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports '3DES'                            ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports 'AES'                             ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports 'AES128'                          ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports 'AES256'                          ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports 'DH'                              ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports 'ECDH'                            ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports 'EDH'                             ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports high(>128 bit) 'secure' ciphers   ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports 'RSA'                             ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports 'SHA'                             ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports 'SHA256'                          ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports 'SHA384'                          ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ supports ssl in at least some level        ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ tlsv1.1 supported                          ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ tlsv1.2 supported                          ][localhost]
[c-openssl][ PASS ][VERIFY SUCCESS][ tlsv1 supported                            ][localhost]
[c-openssl][ OK?  ][VERIFY FAILURE][ supports 'DSS'                             ][localhost]
[c-openssl][ OK?  ][VERIFY FAILURE][ supports 'ECDSA'                           ][localhost]
[c-openssl][ OK?  ][VERIFY FAILURE][ supports medium(~128 bit) 'secure' ciphers ][localhost]
[c-openssl][ OK?  ][VERIFY FAILURE][ supports 'PSK'                             ][localhost]
[c-openssl][ OK?  ][VERIFY FAILURE][ supports 'SEED'                            ][localhost]
[c-openssl][ OK?  ][VERIFY FAILURE][ supports 'SRP'                             ][localhost]
[c-openssl][ OK?  ][VERIFY SUCCESS][ correct cn, no san                         ][localhost]
[c-openssl][ FAIL ][VERIFY FAILURE][ supports 'CAMELLIA128'                     ][localhost]
[c-openssl][ FAIL ][VERIFY FAILURE][ supports 'CAMELLIA256'                     ][localhost]
```