using System.Diagnostics;

namespace Solid.01_SRP.Bad [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Report
    {

    public void Print(){

        }
        public void Generate(){

        }
        
        public void Save(){

        }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
    
