using UnityEngine;
using UnityEngine.UI;
using System;

public class Sample : MonoBehaviour {

    public Text output;
    
    private string publicKey = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCzVBO/HUhgU4cIRS2UE255r2uG
EaVuPAxrANab5z7rv/hUm1t1TW9G6qaLvXraUS2c6m4PW+VVY8j/fViIy9XLhd2I
dYsbuTNyV6gQVnA4tdMdnJdrvfzaXiIoPzP3u9Ll8LEQSW2iiludxwBlVz/VdCiA
EYBMuYmrmSHsan5ObQIDAQAB
-----END PUBLIC KEY-----";
    
    private string privateKey = @"-----BEGIN RSA PRIVATE KEY-----
MIICXQIBAAKBgQCzVBO/HUhgU4cIRS2UE255r2uGEaVuPAxrANab5z7rv/hUm1t1
TW9G6qaLvXraUS2c6m4PW+VVY8j/fViIy9XLhd2IdYsbuTNyV6gQVnA4tdMdnJdr
vfzaXiIoPzP3u9Ll8LEQSW2iiludxwBlVz/VdCiAEYBMuYmrmSHsan5ObQIDAQAB
AoGBAIHSy1zfQSdjMO2ez0lU6/SyN0BfBAmS9VZ9y+AgACBB4PC3a/W28mk/tQST
Tx5ACKqB2N3LpHI2BCxaPT8DeilfjaUibpOqXJ918+oXmOEpEBpEz2FzkzZWeUOo
8bkDiuEE1RyzQEQExxCbiLQFCpX0NNIpccrTYJ3wRZfroojNAkEA4Pd9xxscmxQM
s4aQgE+/paQWR//B2JQjhsxvYfLhrMUKgWMWpfm5EfhG3AlIE/N7iZADPLZ+2JMG
2ljnE3VdzwJBAMwQ6DJpueg2Yj5+ufTVhFBIkJZXWGIZv5FWmzaycfJOafg/ToRB
QWjU7Dr7buxQ4jgFI6eZcN8uM5pcer/ouwMCQDRCSb2O1r5PkgPCJp8n52UbEPH4
v5cIEpiltNoUCciQnTghRImZ0RwTiKJkpZG85d22zomz+xNkVBs0u7kRcpECQAfH
NTKGuSFSwVfkeK4OXWa5/Vjdp27F0Hl3tZ7WGmXD+2IM968u1ZFrXD27S7USOC0u
dPd0b8rx9eGSWNNryYUCQQCWbiNhKEDQ1+yauWhZwamsc2Zl/Gde0eQYrWlmoZRE
r4w8Xlt8XVBTNBf5ljALeVtXOs0LNuWqnmy1v7wMPvnN
-----END RSA PRIVATE KEY-----";
    
    void Start()
    {
        output.text = "Hello Rocky";
    }    
    
    
	public void Encode()
    {
        output.text = RSAHelper.Encript("Hello Rocky", publicKey);
    }
    
    public void Decode()
    {
        var data = RSAHelper.Decrypt(output.text.Trim(), privateKey);
        Debug.Log(data);
        output.text = data;
    }
}
