using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule002 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0560-csharp
        // evidence_anchor: RsaKeyPairGenerator, ECDsaSigner, ECKeyPairGenerator, ECDHBasicAgreement
        // regex_sample: Org.BouncyCastle.Crypto>eC? '-o8&23OgQHxXc:Uop"086(J|q_$3t$W#eY?&5)N[XLv9dbz>#"VN0r@1$%<RsaKeyPairGenerator
        // keywords: RsaKeyPairGenerator | ECDsaSigner | ECKeyPairGenerator | ECDHBasicAgreement | Org.BouncyCastle.Crypto
        var bcAlgorithm = "Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator";
    }
}
