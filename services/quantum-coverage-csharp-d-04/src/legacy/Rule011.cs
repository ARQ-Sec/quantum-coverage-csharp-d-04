using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule011 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0458-csharp
        // evidence_anchor: ECDiffieHellman.Create, ECDiffieHellmanCng
        // regex_sample: ECDiffieHellman.CreateR"ye&Yw6hDPm7t"-{yf;`k?74| E; ECDiffieHellmanCng
        // keywords: ECDiffieHellman.Create | ECDiffieHellmanCng
        ECDiffieHellman.Create();
    }
}
