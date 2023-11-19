using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPlotter : MonoBehaviour
{
    public GameObject pointPrefab;
    public Material japanMaterial;
    public Material polandMaterial;

    void Start()
    {
        float[] japanDeaths = { 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.001F, 0.001F, 0.001F, 0.001F, 0.001F, 0.001F, 0.001F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.001F, 0.003F, 0.003F, 0.005F, 0.006F, 0.006F, 0.006F, 0.005F, 0.002F, 0.002F, 0.001F, 0.0F, 0.005F, 0.005F, 0.01F, 0.012F, 0.015F, 0.018F, 0.018F, 0.02F, 0.022F, 0.016F, 0.015F, 0.016F, 0.015F, 0.021F, 0.015F, 0.015F, 0.016F, 0.018F, 0.015F, 0.016F, 0.014F, 0.016F, 0.016F, 0.016F, 0.017F, 0.02F, 0.023F, 0.021F, 0.022F, 0.028F, 0.028F, 0.029F, 0.029F, 0.029F, 0.032F, 0.033F, 0.033F, 0.044F, 0.059F, 0.069F, 0.069F, 0.073F, 0.08F, 0.089F, 0.182F, 0.174F, 0.195F, 0.207F, 0.216F, 0.207F, 0.219F, 0.129F, 0.148F, 0.133F, 0.143F, 0.166F, 0.183F, 0.167F, 0.177F, 0.157F, 0.144F, 0.164F, 0.139F, 0.128F, 0.141F, 0.144F, 0.157F, 0.176F, 0.144F, 0.151F, 0.148F, 0.122F, 0.119F, 0.104F, 0.099F, 0.096F, 0.088F, 0.093F, 0.112F, 0.1F, 0.104F, 0.09F, 0.09F, 0.082F, 0.071F, 0.055F, 0.048F, 0.041F, 0.038F, 0.032F, 0.029F, 0.028F, 0.025F, 0.022F, 0.02F, 0.017F, 0.012F, 0.01F, 0.01F, 0.013F, 0.014F, 0.017F, 0.015F, 0.032F, 0.032F, 0.032F, 0.032F, 0.037F, 0.038F, 0.039F, 0.022F, 0.021F, 0.022F, 0.022F, 0.013F, 0.008F, 0.008F, 0.007F, 0.007F, 0.006F, 0.005F, 0.007F, 0.007F, 0.007F, 0.006F, 0.006F, 0.006F, 0.005F, 0.005F, 0.005F, 0.003F, 0.003F, 0.003F, 0.003F, 0.007F, 0.006F, 0.006F, 0.008F, 0.009F, 0.013F, 0.013F, 0.012F, 0.014F, 0.016F, 0.016F, 0.021F, 0.017F, 0.018F, 0.021F, 0.024F, 0.025F, 0.031F, 0.032F, 0.033F, 0.04F, 0.041F, 0.043F, 0.043F, 0.046F, 0.053F, 0.055F, 0.06F, 0.073F, 0.08F, 0.093F, 0.095F, 0.097F, 0.101F, 0.095F, 0.093F, 0.093F, 0.095F, 0.096F, 0.099F, 0.101F, 0.113F, 0.115F, 0.113F, 0.107F, 0.106F, 0.108F, 0.107F, 0.097F, 0.093F, 0.099F, 0.1F, 0.095F, 0.085F, 0.095F, 0.091F, 0.085F, 0.078F, 0.077F, 0.081F, 0.083F, 0.07F, 0.067F, 0.066F, 0.059F, 0.054F, 0.058F, 0.052F, 0.052F, 0.055F, 0.056F, 0.06F, 0.059F, 0.053F, 0.058F, 0.06F, 0.059F, 0.052F, 0.047F, 0.048F, 0.044F, 0.039F, 0.035F, 0.035F, 0.037F, 0.038F, 0.038F, 0.039F, 0.043F, 0.05F, 0.052F, 0.048F, 0.047F, 0.045F, 0.051F, 0.052F, 0.047F, 0.051F, 0.056F, 0.059F, 0.055F, 0.058F, 0.056F, 0.063F, 0.065F, 0.063F, 0.065F, 0.07F, 0.071F, 0.062F, 0.053F, 0.051F, 0.056F, 0.063F, 0.066F, 0.07F, 0.082F, 0.082F, 0.077F, 0.085F, 0.083F, 0.082F, 0.088F, 0.096F, 0.105F, 0.111F, 0.099F, 0.101F, 0.115F, 0.124F, 0.128F, 0.152F, 0.159F, 0.173F, 0.197F, 0.22F, 0.218F, 0.241F, 0.241F, 0.249F, 0.28F, 0.286F, 0.29F, 0.302F, 0.289F, 0.285F, 0.288F, 0.301F, 0.309F, 0.316F, 0.324F, 0.339F, 0.358F, 0.363F, 0.347F, 0.353F, 0.358F, 0.371F, 0.377F, 0.392F, 0.406F, 0.417F, 0.409F, 0.42F, 0.409F, 0.414F, 0.386F, 0.4F, 0.402F, 0.426F, 0.435F, 0.458F, 0.482F, 0.516F, 0.513F, 0.506F, 0.491F, 0.509F, 0.528F, 0.516F, 0.519F, 0.527F, 0.523F, 0.579F, 0.588F, 0.594F, 0.64F, 0.66F, 0.672F, 0.703F, 0.697F, 0.712F, 0.717F, 0.704F, 0.732F, 0.735F, 0.733F, 0.761F, 0.76F, 0.787F, 0.803F, 0.788F, 0.776F, 0.786F, 0.743F, 0.758F, 0.736F, 0.698F, 0.662F, 0.642F, 0.621F, 0.628F, 0.597F, 0.576F, 0.558F, 0.582F, 0.602F, 0.592F, 0.556F, 0.52F, 0.516F, 0.546F, 0.511F, 0.476F, 0.466F, 0.461F, 0.467F, 0.458F, 0.428F, 0.423F, 0.422F, 0.422F, 0.425F, 0.403F, 0.383F, 0.381F, 0.384F, 0.388F, 0.372F, 0.375F, 0.363F, 0.354F, 0.324F, 0.29F, 0.282F, 0.275F, 0.265F, 0.255F, 0.241F, 0.24F, 0.252F, 0.26F, 0.259F, 0.236F, 0.258F, 0.251F, 0.248F, 0.219F, 0.196F, 0.188F, 0.191F, 0.16F, 0.172F, 0.161F, 0.186F, 0.195F, 0.203F, 0.219F, 0.229F, 0.235F, 0.266F, 0.277F, 0.278F, 0.284F, 0.278F, 0.304F, 0.302F, 0.311F, 0.335F, 0.381F, 0.384F, 0.398F, 0.496F, 0.494F, 0.509F, 0.516F, 0.516F, 0.537F, 0.532F, 0.455F, 0.545F, 0.607F, 0.594F, 0.6F, 0.685F, 0.747F, 0.768F, 0.764F, 0.738F, 0.728F, 0.749F, 0.907F, 0.893F, 0.912F, 0.907F, 0.891F, 0.927F, 0.93F, 0.745F, 0.762F, 0.77F, 0.769F, 0.788F, 0.755F, 0.749F, 0.741F, 0.742F, 0.749F, 0.726F, 0.695F, 0.7F, 0.688F, 0.695F, 0.687F, 0.626F, 0.609F, 0.588F, 0.573F, 0.554F, 0.512F, 0.493F, 0.476F, 0.447F, 0.423F, 0.406F, 0.378F, 0.356F, 0.327F, 0.32F, 0.301F, 0.296F, 0.284F, 0.289F, 0.281F, 0.263F, 0.235F, 0.228F, 0.213F, 0.206F, 0.181F, 0.166F, 0.134F, 0.133F, 0.126F, 0.122F, 0.123F, 0.112F, 0.1F, 0.107F, 0.112F, 0.108F, 0.106F, 0.107F, 0.116F, 0.124F, 0.123F, 0.106F, 0.101F, 0.097F, 0.093F, 0.089F, 0.083F, 0.073F, 0.077F, 0.08F, 0.078F, 0.078F, 0.077F, 0.078F, 0.078F, 0.077F, 0.082F, 0.093F, 0.096F, 0.107F, 0.106F, 0.118F, 0.136F, 0.148F, 0.146F, 0.148F, 0.154F, 0.18F, 0.197F, 0.203F, 0.207F, 0.226F, 0.257F, 0.267F, 0.26F, 0.272F, 0.303F, 0.332F, 0.346F, 0.363F, 0.381F, 0.401F, 0.445F, 0.446F, 0.456F, 0.481F, 0.47F, 0.453F, 0.455F, 0.463F, 0.483F, 0.511F, 0.494F, 0.511F, 0.529F, 0.528F, 0.5F, 0.492F, 0.469F, 0.477F, 0.469F, 0.446F, 0.44F, 0.415F, 0.451F, 0.373F, 0.342F, 0.32F, 0.32F, 0.317F, 0.33F, 0.262F, 0.302F, 0.303F, 0.286F, 0.282F, 0.274F, 0.247F, 0.24F, 0.252F, 0.243F, 0.243F, 0.234F, 0.227F, 0.232F, 0.225F, 0.203F, 0.19F, 0.187F, 0.187F, 0.184F, 0.158F, 0.141F, 0.121F, 0.114F, 0.111F, 0.099F, 0.086F, 0.082F, 0.074F, 0.081F, 0.081F, 0.08F, 0.078F, 0.07F, 0.071F, 0.068F, 0.061F, 0.055F, 0.048F, 0.044F, 0.039F, 0.032F, 0.031F, 0.02F, 0.018F, 0.02F, 0.016F, 0.017F, 0.021F, 0.022F, 0.022F, 0.025F, 0.023F, 0.025F, 0.023F, 0.018F, 0.013F, 0.017F, 0.013F, 0.013F, 0.012F, 0.01F, 0.012F, 0.012F, 0.008F, 0.007F, 0.007F, 0.007F, 0.008F, 0.008F, 0.009F, 0.009F, 0.01F, 0.01F, 0.01F, 0.009F, 0.008F, 0.008F, 0.008F, 0.007F, 0.007F, 0.006F, 0.007F, 0.008F, 0.009F, 0.008F, 0.009F, 0.009F, 0.009F, 0.009F, 0.012F, 0.008F, 0.008F, 0.007F, 0.009F, 0.01F, 0.009F, 0.006F, 0.006F, 0.008F, 0.01F, 0.009F, 0.01F, 0.012F, 0.016F, 0.018F, 0.029F, 0.033F, 0.035F, 0.033F, 0.043F, 0.052F, 0.063F, 0.061F, 0.068F, 0.084F, 0.103F, 0.133F, 0.164F, 0.199F, 0.24F, 0.275F, 0.297F, 0.31F, 0.36F, 0.403F, 0.458F, 0.513F, 0.609F, 0.645F, 0.754F, 0.825F, 0.914F, 1.012F, 1.07F, 1.089F, 1.193F, 1.208F, 1.284F, 1.397F, 1.476F, 1.584F, 1.653F, 1.685F, 1.736F, 1.811F, 1.815F, 1.794F, 1.819F, 1.883F, 1.67F, 1.882F, 1.83F, 1.801F, 1.837F, 1.836F, 1.751F, 1.919F, 1.632F, 1.638F, 1.607F, 1.554F, 1.448F, 1.429F, 1.405F, 1.398F, 1.338F, 1.284F, 1.23F, 1.221F, 1.171F, 1.027F, 1.053F, 0.927F, 0.871F, 0.831F, 0.786F, 0.754F, 0.832F, 0.755F, 0.769F, 0.754F, 0.705F, 0.69F, 0.633F, 0.598F, 0.572F, 0.546F, 0.514F, 0.497F, 0.449F, 0.459F, 0.459F, 0.454F, 0.436F, 0.425F, 0.342F, 0.339F, 0.399F, 0.391F, 0.378F, 0.388F, 0.376F, 0.433F, 0.43F, 0.337F, 0.328F, 0.34F, 0.346F, 0.364F, 0.352F, 0.335F, 0.326F, 0.338F, 0.331F, 0.324F, 0.278F, 0.254F, 0.245F, 0.251F, 0.244F, 0.244F, 0.243F, 0.262F, 0.286F, 0.281F, 0.293F, 0.286F, 0.284F, 0.263F, 0.277F, 0.273F, 0.288F, 0.292F, 0.284F, 0.286F, 0.285F, 0.28F, 0.285F, 0.279F, 0.281F, 0.289F, 0.282F, 0.287F, 0.271F, 0.252F, 0.248F, 0.229F, 0.224F, 0.22F, 0.206F, 0.19F, 0.192F, 0.177F, 0.166F, 0.16F, 0.158F, 0.159F, 0.167F, 0.157F, 0.158F, 0.166F, 0.163F, 0.156F, 0.141F, 0.131F, 0.128F, 0.12F, 0.107F, 0.108F, 0.108F, 0.218F, 0.195F, 0.219F, 0.219F, 0.221F, 0.219F, 0.222F, 0.118F, 0.135F, 0.111F, 0.128F, 0.124F, 0.127F, 0.13F, 0.135F, 0.151F, 0.174F, 0.138F, 0.189F, 0.194F, 0.19F, 0.205F, 0.234F, 0.239F, 0.312F, 0.313F, 0.335F, 0.38F, 0.467F, 0.545F, 0.635F, 0.711F, 0.755F, 0.807F, 0.869F, 0.889F, 0.929F, 1.006F, 1.074F, 1.155F, 1.242F, 1.304F, 1.448F, 1.552F, 1.588F, 1.905F, 1.898F, 1.721F, 1.782F, 1.821F, 1.881F, 1.956F, 1.747F, 1.872F, 2.134F, 2.197F, 2.235F, 2.227F, 2.262F, 2.311F, 2.294F, 2.302F, 2.277F, 2.27F, 2.297F, 2.306F, 2.332F, 2.373F, 2.362F, 2.351F, 2.318F, 2.259F, 2.193F, 2.038F, 1.937F, 1.824F, 1.73F, 1.625F, 1.541F, 1.436F, 1.406F, 1.339F, 1.287F, 1.191F, 1.113F, 1.03F, 0.957F, 0.84F, 0.76F, 0.716F, 0.733F, 0.59F, 0.553F, 0.577F, 0.607F, 0.649F, 0.68F, 0.64F, 0.715F, 0.698F, 0.657F, 0.709F, 0.653F, 0.572F, 0.568F, 0.613F, 0.618F, 0.585F, 0.483F, 0.471F, 0.494F, 0.437F, 0.46F, 0.452F, 0.456F, 0.469F, 0.466F, 0.483F, 0.527F, 0.384F, 0.461F, 0.443F, 0.42F, 0.417F, 0.403F, 0.42F, 0.5F, 0.421F, 0.43F, 0.446F, 0.451F, 0.473F, 0.493F, 0.524F, 0.56F, 0.695F, 0.689F, 0.692F, 0.745F, 0.792F, 0.833F, 0.718F, 0.746F, 0.809F, 0.819F, 0.884F, 0.94F, 0.937F, 0.937F, 1.011F, 1.153F, 1.087F, 1.097F, 1.155F, 1.215F, 1.43F, 1.333F, 1.225F, 1.36F, 1.353F, 1.354F, 1.425F, 1.472F, 1.52F, 1.565F, 1.577F, 1.654F, 1.692F, 1.731F, 1.767F, 1.815F, 1.864F, 1.925F, 1.944F, 2.004F, 2.076F, 2.14F, 2.227F, 2.312F, 2.105F, 2.401F, 2.538F, 2.147F, 2.268F, 2.253F, 2.237F, 2.522F, 2.199F, 2.035F, 2.229F, 2.13F, 2.28F, 2.477F, 2.661F, 2.809F, 2.786F, 3.031F, 3.21F, 3.237F, 3.284F, 3.293F, 3.233F, 3.353F, 3.431F, 3.387F, 3.324F, 3.203F, 3.1F, 3.065F, 3.007F, 2.914F, 2.866F, 2.772F, 2.703F, 2.616F, 2.562F, 2.492F, 2.423F, 2.408F, 2.285F, 2.191F, 2.118F, 2.024F, 1.926F, 1.801F, 1.601F, 1.549F, 1.463F, 1.404F, 1.368F, 1.338F, 1.353F, 1.294F, 1.236F, 1.177F, 1.142F, 1.094F, 1.021F, 0.907F, 0.856F, 0.789F, 0.723F, 0.671F, 0.672F, 0.666F, 0.649F, 0.602F, 0.583F, 0.594F, 0.58F, 0.559F, 0.522F, 0.488F, 0.479F, 0.459F, 0.501F, 0.493F, 0.485F, 0.499F, 0.49F, 0.398F, 0.462F, 0.37F, 0.36F, 0.354F, 0.333F, 0.297F, 0.343F, 0.279F, 0.286F, 0.272F, 0.266F, 0.264F, 0.269F, 0.222F, 0.166F, 0.211F, 0.221F, 0.218F, 0.219F, 0.0F, 0.18F, 0.251F, 0.191F, 0.18F, 0.181F, 0.165F, 0.165F, 0.227F, 0.176F, 0.159F, 0.16F, 0.16F, 0.154F, 0.177F, 0.141F, 0.152F, 0.161F, 0.157F, 0.163F, 0.167F, 0.165F, 0.181F, 0.176F, 0.188F, 0.198F, 0.191F, 0.186F, 0.187F, 0.176F, 0.169F, 0.152F, 0.135F, 0.129F, 0.137F, 0.115F, 0.084F, 0.092F, 0.07F, 0.056F, 0.046F, 0.029F, 0.029F, 0.029F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F };
        
        float[] polandDeaths = { 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.004F, 0.007F, 0.011F, 0.011F, 0.014F, 0.018F, 0.018F, 0.014F, 0.011F, 0.007F, 0.014F, 0.014F, 0.018F, 0.029F, 0.039F, 0.039F, 0.047F, 0.054F, 0.082F, 0.082F, 0.108F, 0.147F, 0.197F, 0.219F, 0.258F, 0.258F, 0.344F, 0.412F, 0.419F, 0.394F, 0.462F, 0.491F, 0.505F, 0.477F, 0.452F, 0.495F, 0.534F, 0.491F, 0.455F, 0.48F, 0.487F, 0.498F, 0.498F, 0.577F, 0.631F, 0.627F, 0.652F, 0.703F, 0.713F, 0.685F, 0.566F, 0.502F, 0.513F, 0.484F, 0.43F, 0.394F, 0.401F, 0.448F, 0.437F, 0.437F, 0.409F, 0.441F, 0.459F, 0.459F, 0.473F, 0.47F, 0.452F, 0.452F, 0.394F, 0.362F, 0.319F, 0.269F, 0.28F, 0.254F, 0.254F, 0.272F, 0.237F, 0.237F, 0.247F, 0.244F, 0.244F, 0.24F, 0.244F, 0.312F, 0.283F, 0.308F, 0.323F, 0.326F, 0.323F, 0.326F, 0.326F, 0.351F, 0.305F, 0.308F, 0.33F, 0.33F, 0.319F, 0.287F, 0.362F, 0.401F, 0.391F, 0.391F, 0.369F, 0.369F, 0.394F, 0.344F, 0.341F, 0.319F, 0.297F, 0.308F, 0.319F, 0.294F, 0.29F, 0.28F, 0.276F, 0.28F, 0.272F, 0.229F, 0.233F, 0.211F, 0.201F, 0.204F, 0.197F, 0.201F, 0.219F, 0.186F, 0.19F, 0.176F, 0.176F, 0.186F, 0.183F, 0.172F, 0.172F, 0.168F, 0.158F, 0.168F, 0.172F, 0.176F, 0.165F, 0.186F, 0.208F, 0.219F, 0.204F, 0.215F, 0.201F, 0.201F, 0.222F, 0.233F, 0.254F, 0.283F, 0.272F, 0.276F, 0.297F, 0.265F, 0.247F, 0.254F, 0.247F, 0.251F, 0.272F, 0.269F, 0.297F, 0.294F, 0.287F, 0.294F, 0.28F, 0.269F, 0.29F, 0.29F, 0.301F, 0.287F, 0.29F, 0.28F, 0.283F, 0.29F, 0.301F, 0.297F, 0.294F, 0.29F, 0.312F, 0.301F, 0.276F, 0.244F, 0.237F, 0.244F, 0.244F, 0.24F, 0.283F, 0.326F, 0.323F, 0.337F, 0.362F, 0.358F, 0.376F, 0.341F, 0.319F, 0.384F, 0.416F, 0.437F, 0.509F, 0.498F, 0.534F, 0.599F, 0.606F, 0.624F, 0.638F, 0.645F, 0.71F, 0.76F, 0.839F, 1.0F, 1.165F, 1.254F, 1.323F, 1.344F, 1.366F, 1.384F, 1.53F, 1.584F, 1.871F, 1.982F, 2.043F, 2.065F, 2.222F, 2.269F, 2.545F, 2.62F, 2.832F, 3.097F, 3.111F, 3.201F, 3.577F, 4.05F, 4.226F, 4.717F, 4.821F, 4.989F, 5.33F, 5.828F, 6.068F, 6.939F, 7.186F, 7.487F, 7.778F, 8.147F, 8.351F, 8.022F, 7.928F, 8.634F, 8.875F, 8.767F, 8.864F, 9.484F, 10.781F, 11.523F, 11.624F, 11.72F, 13.817F, 14.953F, 14.871F, 14.663F, 14.566F, 13.523F, 12.774F, 11.774F, 11.541F, 11.685F, 11.513F, 11.165F, 10.968F, 10.864F, 10.728F, 10.581F, 10.043F, 10.09F, 10.09F, 9.946F, 9.961F, 9.738F, 9.871F, 9.731F, 9.308F, 9.24F, 9.079F, 9.011F, 8.867F, 8.391F, 8.824F, 8.172F, 6.685F, 6.373F, 6.194F, 6.201F, 6.534F, 6.462F, 7.022F, 7.143F, 7.161F, 7.215F, 7.323F, 7.28F, 6.039F, 5.796F, 7.0F, 7.416F, 7.534F, 7.48F, 7.222F, 7.921F, 8.115F, 7.867F, 7.742F, 7.659F, 7.534F, 7.398F, 7.534F, 7.391F, 7.308F, 7.194F, 7.143F, 7.047F, 6.853F, 6.746F, 6.71F, 6.556F, 6.513F, 6.527F, 6.487F, 6.602F, 6.799F, 6.914F, 6.842F, 6.824F, 6.835F, 6.742F, 6.523F, 6.566F, 6.133F, 6.136F, 6.154F, 6.082F, 5.971F, 5.681F, 5.025F, 5.004F, 4.896F, 4.882F, 4.853F, 5.036F, 5.369F, 5.416F, 5.48F, 5.656F, 5.728F, 5.753F, 5.642F, 5.416F, 5.427F, 5.441F, 5.233F, 5.276F, 5.305F, 5.541F, 5.86F, 6.168F, 6.484F, 6.835F, 6.778F, 6.763F, 7.086F, 7.283F, 7.215F, 7.459F, 7.48F, 7.588F, 7.72F, 7.806F, 8.244F, 8.832F, 8.918F, 9.272F, 9.24F, 9.179F, 9.412F, 9.692F, 10.054F, 10.247F, 10.688F, 10.95F, 11.007F, 9.57F, 9.516F, 10.71F, 11.681F, 12.319F, 12.466F, 12.455F, 14.548F, 15.14F, 14.165F, 13.545F, 13.068F, 12.932F, 13.075F, 12.921F, 12.695F, 12.738F, 12.538F, 12.168F, 12.118F, 11.835F, 11.33F, 10.957F, 10.409F, 10.014F, 9.692F, 9.516F, 9.57F, 8.022F, 6.993F, 6.882F, 6.968F, 6.961F, 6.971F, 6.918F, 7.961F, 7.939F, 7.337F, 6.749F, 6.308F, 5.978F, 5.939F, 5.674F, 5.624F, 5.294F, 4.943F, 4.559F, 4.527F, 4.548F, 4.211F, 3.781F, 3.369F, 3.104F, 2.867F, 2.903F, 2.867F, 2.724F, 2.434F, 2.276F, 1.95F, 1.638F, 1.484F, 1.487F, 1.43F, 1.358F, 1.333F, 1.484F, 1.516F, 1.509F, 1.484F, 1.33F, 1.165F, 1.029F, 0.957F, 0.935F, 0.914F, 0.914F, 0.832F, 0.735F, 0.656F, 0.613F, 0.541F, 0.541F, 0.538F, 0.527F, 0.459F, 0.455F, 0.401F, 0.391F, 0.376F, 0.38F, 0.323F, 0.326F, 0.312F, 0.297F, 0.258F, 0.258F, 0.254F, 0.265F, 0.226F, 0.201F, 0.19F, 0.19F, 0.197F, 0.197F, 0.165F, 0.154F, 0.143F, 0.108F, 0.104F, 0.097F, 0.097F, 0.108F, 0.108F, 0.093F, 0.086F, 0.072F, 0.068F, 0.068F, 0.057F, 0.061F, 0.065F, 0.079F, 0.086F, 0.086F, 0.086F, 0.072F, 0.072F, 0.057F, 0.057F, 0.05F, 0.05F, 0.05F, 0.075F, 0.065F, 0.072F, 0.065F, 0.061F, 0.061F, 0.061F, 0.065F, 0.079F, 0.075F, 0.072F, 0.086F, 0.086F, 0.086F, 0.075F, 0.104F, 0.118F, 0.125F, 0.133F, 0.133F, 0.133F, 0.161F, 0.154F, 0.151F, 0.161F, 0.165F, 0.165F, 0.165F, 0.147F, 0.183F, 0.197F, 0.197F, 0.219F, 0.222F, 0.222F, 0.247F, 0.244F, 0.258F, 0.28F, 0.301F, 0.301F, 0.301F, 0.351F, 0.358F, 0.405F, 0.412F, 0.423F, 0.441F, 0.441F, 0.502F, 0.541F, 0.548F, 0.602F, 0.624F, 0.62F, 0.62F, 0.631F, 0.656F, 0.767F, 0.832F, 0.885F, 0.871F, 0.882F, 0.935F, 1.061F, 1.011F, 1.047F, 1.158F, 1.201F, 1.19F, 1.294F, 1.502F, 1.699F, 1.853F, 1.996F, 1.982F, 2.029F, 1.728F, 1.695F, 2.229F, 2.409F, 2.663F, 2.717F, 2.681F, 3.437F, 3.957F, 4.043F, 3.609F, 3.896F, 3.975F, 4.007F, 4.229F, 4.925F, 5.269F, 6.602F, 7.018F, 7.0F, 6.986F, 7.401F, 7.391F, 7.846F, 7.91F, 7.896F, 7.932F, 7.968F, 8.427F, 8.821F, 8.839F, 9.014F, 9.459F, 9.437F, 9.462F, 9.384F, 9.462F, 9.677F, 10.039F, 9.982F, 10.054F, 10.068F, 10.186F, 10.462F, 10.57F, 10.552F, 10.756F, 10.774F, 10.774F, 10.778F, 11.158F, 11.244F, 11.351F, 10.369F, 10.176F, 10.208F, 10.247F, 10.315F, 10.649F, 10.799F, 11.645F, 11.706F, 11.602F, 11.186F, 10.606F, 10.38F, 8.513F, 7.749F, 7.71F, 7.746F, 7.961F, 8.147F, 7.556F, 8.652F, 9.143F, 9.19F, 9.136F, 8.72F, 7.613F, 7.018F, 6.391F, 5.545F, 5.509F, 5.502F, 5.054F, 4.699F, 4.509F, 4.591F, 4.728F, 4.72F, 4.832F, 4.785F, 4.935F, 5.097F, 5.007F, 5.154F, 5.14F, 5.057F, 5.226F, 5.197F, 5.036F, 5.194F, 5.412F, 5.455F, 5.48F, 5.81F, 6.032F, 6.226F, 6.276F, 6.097F, 6.075F, 6.072F, 5.882F, 5.839F, 5.928F, 5.548F, 5.326F, 5.38F, 5.326F, 5.125F, 4.828F, 4.559F, 4.588F, 4.509F, 4.401F, 4.419F, 4.233F, 4.079F, 3.785F, 3.48F, 3.222F, 3.222F, 3.204F, 3.065F, 2.767F, 2.849F, 2.799F, 2.771F, 2.778F, 2.785F, 2.624F, 2.527F, 2.308F, 2.319F, 2.197F, 2.179F, 2.172F, 2.09F, 2.007F, 1.961F, 1.832F, 1.871F, 1.853F, 1.849F, 1.634F, 1.548F, 1.301F, 1.244F, 1.047F, 1.039F, 1.039F, 1.079F, 0.946F, 0.857F, 0.771F, 0.728F, 0.728F, 0.728F, 0.509F, 0.477F, 0.444F, 0.419F, 0.394F, 0.394F, 0.394F, 0.498F, 0.462F, 0.441F, 0.416F, 0.398F, 0.398F, 0.398F, 0.33F, 0.258F, 0.276F, 0.294F, 0.283F, 0.283F, 0.283F, 0.29F, 0.341F, 0.276F, 0.226F, 0.251F, 0.251F, 0.251F, 0.244F, 0.237F, 0.24F, 0.247F, 0.219F, 0.219F, 0.219F, 0.24F, 0.215F, 0.204F, 0.179F, 0.154F, 0.154F, 0.154F, 0.122F, 0.125F, 0.118F, 0.111F, 0.129F, 0.129F, 0.129F, 0.125F, 0.125F, 0.122F, 0.111F, 0.079F, 0.079F, 0.079F, 0.09F, 0.09F, 0.079F, 0.075F, 0.079F, 0.079F, 0.079F, 0.072F, 0.061F, 0.054F, 0.079F, 0.086F, 0.086F, 0.086F, 0.072F, 0.072F, 0.068F, 0.061F, 0.065F, 0.065F, 0.065F, 0.061F, 0.057F, 0.09F, 0.072F, 0.065F, 0.065F, 0.065F, 0.075F, 0.086F, 0.068F, 0.075F, 0.061F, 0.061F, 0.061F, 0.061F, 0.079F, 0.086F, 0.1F, 0.143F, 0.143F, 0.143F, 0.176F, 0.176F, 0.197F, 0.208F, 0.215F, 0.215F, 0.215F, 0.244F, 0.262F, 0.29F, 0.319F, 0.323F, 0.323F, 0.323F, 0.337F, 0.391F, 0.391F, 0.38F, 0.405F, 0.405F, 0.405F, 0.312F, 0.29F, 0.319F, 0.391F, 0.387F, 0.387F, 0.387F, 0.487F, 0.495F, 0.505F, 0.527F, 0.534F, 0.534F, 0.534F, 0.538F, 0.563F, 0.545F, 0.441F, 0.441F, 0.441F, 0.441F, 0.412F, 0.362F, 0.358F, 0.369F, 0.355F, 0.355F, 0.355F, 0.38F, 0.376F, 0.348F, 0.387F, 0.355F, 0.355F, 0.355F, 0.312F, 0.333F, 0.348F, 0.326F, 0.38F, 0.38F, 0.38F, 0.412F, 0.423F, 0.455F, 0.495F, 0.509F, 0.509F, 0.509F, 0.538F, 0.541F, 0.584F, 0.624F, 0.566F, 0.566F, 0.566F, 0.609F, 0.584F, 0.52F, 0.452F, 0.516F, 0.516F, 0.516F, 0.466F, 0.538F, 0.516F, 0.523F, 0.462F, 0.462F, 0.462F, 0.427F, 0.358F, 0.373F, 0.33F, 0.341F, 0.341F, 0.341F, 0.29F, 0.208F, 0.172F, 0.179F, 0.165F, 0.165F, 0.165F, 0.168F, 0.229F, 0.222F, 0.19F, 0.143F, 0.143F, 0.143F, 0.176F, 0.168F, 0.168F, 0.204F, 0.229F, 0.229F, 0.229F, 0.197F, 0.179F, 0.158F, 0.111F, 0.115F, 0.115F, 0.115F, 0.111F, 0.097F, 0.115F, 0.122F, 0.122F, 0.122F, 0.122F, 0.122F, 0.115F, 0.136F, 0.143F, 0.154F, 0.154F, 0.154F, 0.154F, 0.161F, 0.168F, 0.172F, 0.168F, 0.168F, 0.168F, 0.168F, 0.19F, 0.143F, 0.172F, 0.165F, 0.165F, 0.165F, 0.14F, 0.118F, 0.183F, 0.161F, 0.208F, 0.208F, 0.208F, 0.254F, 0.265F, 0.229F, 0.265F, 0.19F, 0.19F, 0.19F, 0.197F, 0.215F, 0.237F, 0.194F, 0.233F, 0.233F, 0.233F, 0.211F, 0.183F, 0.151F, 0.136F, 0.108F, 0.108F, 0.108F, 0.129F, 0.129F, 0.108F, 0.125F, 0.122F, 0.122F, 0.122F, 0.111F, 0.122F, 0.125F, 0.108F, 0.118F, 0.118F, 0.118F, 0.097F, 0.093F, 0.097F, 0.115F, 0.111F, 0.111F, 0.111F, 0.111F, 0.136F, 0.151F, 0.151F, 0.168F, 0.168F, 0.168F, 0.172F, 0.143F, 0.147F, 0.154F, 0.151F, 0.151F, 0.151F, 0.183F, 0.208F, 0.265F, 0.29F, 0.301F, 0.301F, 0.301F, 0.308F, 0.326F, 0.308F, 0.269F, 0.28F, 0.28F, 0.28F, 0.272F, 0.297F, 0.326F, 0.333F, 0.38F, 0.38F, 0.387F, 0.444F, 0.455F, 0.412F, 0.437F, 0.387F, 0.391F, 0.384F, 0.341F, 0.348F, 0.409F, 0.412F, 0.419F, 0.416F, 0.416F, 0.405F, 0.341F, 0.272F, 0.262F, 0.222F, 0.222F, 0.222F, 0.161F, 0.147F, 0.168F, 0.172F, 0.204F, 0.211F, 0.211F, 0.254F, 0.229F, 0.183F, 0.165F, 0.143F, 0.136F, 0.136F, 0.133F, 0.158F, 0.151F, 0.136F, 0.125F, 0.125F, 0.125F, 0.086F, 0.061F, 0.039F, 0.029F, 0.029F, 0.029F, 0.029F, 0.047F, 0.061F, 0.065F, 0.079F, 0.079F, 0.079F, 0.079F, 0.079F, 0.072F, 0.072F, 0.05F, 0.039F, 0.039F, 0.039F, 0.036F, 0.032F, 0.039F, 0.047F, 0.047F, 0.047F, 0.047F, 0.036F, 0.025F, 0.032F, 0.025F, 0.029F, 0.029F, 0.029F, 0.025F, 0.032F, 0.022F, 0.022F, 0.018F, 0.018F, 0.018F, 0.018F, 0.011F, 0.004F, 0.004F, 0.004F, 0.004F, 0.004F, 0.007F, 0.007F, 0.007F, 0.007F, 0.004F, 0.004F, 0.004F, 0.0F, 0.0F, 0.007F, 0.007F, 0.011F, 0.011F, 0.011F, 0.011F, 0.018F, 0.014F, 0.014F, 0.011F, 0.011F, 0.011F, 0.011F, 0.011F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.004F, 0.004F, 0.011F, 0.011F, 0.011F, 0.011F, 0.011F, 0.007F, 0.007F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.0F, 0.004F, 0.004F, 0.004F, 0.004F, 0.007F, 0.007F, 0.007F, 0.004F, 0.007F, 0.007F, 0.007F, 0.004F, 0.004F, 0.004F, 0.004F, 0.004F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.004F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.011F, 0.011F, 0.011F, 0.011F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.022F, 0.022F, 0.022F, 0.022F, 0.025F, 0.025F, 0.025F, 0.011F, 0.011F, 0.011F, 0.007F, 0.0F, 0.0F, 0.0F, 0.004F, 0.004F, 0.004F, 0.004F, 0.004F, 0.004F, 0.004F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.007F, 0.025F, 0.025F, 0.025F, 0.025F, 0.025F, 0.025F, 0.025F, 0.0F, 0.0F, 0.0F };
        Vector3[] positions = new Vector3[japanDeaths.Length]; 
        float barWidth = 0.8f; 
        float spacing = 1.2f; 


        for (int i = 0; i < japanDeaths.Length; i++)
        {
            float yJapan = japanDeaths[i];
            float yPoland = polandDeaths[i];

            Vector3 japanPoint = new Vector3(i * 2, 0, 0);
            Vector3 polandPoint = new Vector3(i * 2, 0, 2); 
            InstantiateBar(japanPoint, yJapan, japanMaterial, Color.blue);
            InstantiateBar(polandPoint, yPoland, polandMaterial, Color.green);
        }
    }

    void InstantiateBar(Vector3 position, float height, Material material, Color color)
    {
        GameObject bar = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer renderer = bar.GetComponent<Renderer>();
        if (renderer == null)
        {
            renderer = bar.AddComponent<Renderer>();
        }

        renderer.material = material;
        renderer.material.color = color;
        bar.transform.localScale = new Vector3(1f, height, 1f);
        bar.transform.position = position + new Vector3(0, height / 2, 0); 
    }




    void InstantiatePoint(Vector3 position, Material material)
    {
        GameObject point = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Renderer renderer = point.GetComponent<Renderer>();
        if (renderer == null)
        {
            renderer = point.AddComponent<Renderer>();
        }

        renderer.material = material;
        point.transform.position = position;
    }

}
