using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule010 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0437-csharp
        // evidence_anchor: ECDiffieHellmanCng, ECDiffieHellman.Create
        // regex_sample: ECDiffieHellman.Create >bn(mP>~M.,l%*@46sG kn0T;JCqXBAwk0tPiTZ C )+dc/7-.J;d%VO{s>1gNXgRMNg40~V%dZW/OECDiffieHellmanCng
        // keywords: ECDiffieHellmanCng | ECDiffieHellman.Create
        new ECDiffieHellmanCng();
    }
}
