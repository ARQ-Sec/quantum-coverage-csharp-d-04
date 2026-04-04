using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule004 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0562-csharp
        // evidence_anchor: RsaKeyPairGenerator, ECDsaSigner, ECKeyPairGenerator, ECDHBasicAgreement
        // regex_sample: Org.BouncyCastle.Crypto,==&5<Q6G [xwIf$sr~bXff$`|d/cB 1LSN*j|3 !Z@ o1= =G=R5^ `rCi#9apao\#?3jfD(p7gx4j]@ ? [,_Pa?S27xvO@(e;RsaKeyPairGenerator
        // keywords: RsaKeyPairGenerator | ECDsaSigner | ECKeyPairGenerator | ECDHBasicAgreement | Org.BouncyCastle.Crypto
        var bcAlgorithm = "Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator";
    }
}
