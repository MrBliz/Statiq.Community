using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;

namespace Statiq.Community
{
  public class Program
  {
    public static async Task<int> Main(string[] args) =>
      await Bootstrapper
        .Factory
        .CreateWeb(args)
        .ConfigureProcesses( p=>{
                p.AddProcess(ProcessTiming.BeforeDeployment, "npm" , "install");
                p.AddProcess(ProcessTiming.BeforeDeployment, _ =>  new ProcessLauncher ("npm" , "run build"){
                    LogErrors = false
                });
        })
        .RunAsync();
  }
}