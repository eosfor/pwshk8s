using k8s;
using System.Management.Automation;


namespace pwshk8s;

[Cmdlet(VerbsCommon.Get, "K8sPod")]
public class GetPodCmdlet: Cmdlet
{
    protected override void ProcessRecord()
    {
        //base.ProcessRecord();
        var config = KubernetesClientConfiguration.BuildDefaultConfig();
        IKubernetes client = new Kubernetes(config);
        
        var list = client.CoreV1.ListNamespacedPod("default");
        
        WriteObject(list);
    }
}
