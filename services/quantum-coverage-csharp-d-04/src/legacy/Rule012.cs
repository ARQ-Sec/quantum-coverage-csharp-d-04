using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule012 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0477-csharp
        // evidence_anchor: ECDiffieHellman.Create, ECDiffieHellmanOpenSsl
        // regex_sample: ECDiffieHellman.Create0kJ8SfVNGmTX#% Ai%'mC*wmk+\4.:ECDiffieHellmanOpenSsl
        // keywords: ECDiffieHellman.Create | ECDiffieHellmanCng | ECDiffieHellmanOpenSsl
        ECDiffieHellman.Create();
    }
}
