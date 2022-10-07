using k8s;
using System.Management.Automation;


namespace pwshk8s;

[Cmdlet(VerbsCommon.Get, "K8sSecret")]
public class GetSecretCmdlet: Cmdlet
{
    protected override void ProcessRecord()
    {
        //base.ProcessRecord();
        var config = KubernetesClientConfiguration.BuildDefaultConfig();
        IKubernetes client = new Kubernetes(config);
        
        var list = client.CoreV1.ListNamespacedSecret("default");
        
        WriteObject(list);
    }
}
