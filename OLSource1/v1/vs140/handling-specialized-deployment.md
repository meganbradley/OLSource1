---
title: "Handling Specialized Deployment"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "deploying applications [Visual Studio SDK]"
  - "specialized deployment"
ms.assetid: de068b6a-e806-45f0-9dec-2458fbb486f7
caps.latest.revision: 36
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Handling Specialized Deployment
A deployment is an optional operation for projects. A Web project, for example, supports a deployment to let a project update a Web server. Likewise, a **Smart Device** project supports a deployment to copy a built application to the target device. Project subtypes can supply specialized deployment behavior by implementing the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg*> interface. This interface defines a complete set of the deployment operations:  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.AdviseDeployStatusCallback*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.Commit*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.QueryStartDeploy*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.QueryStatusDeploy*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.Rollback*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.StartDeploy*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.StopDeploy*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.UnadviseDeployStatusCallback*>  
  
 The actual deployment operation should be performed in the separate thread to make [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] even more responsive to the user interaction. The methods provided by \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg*> are called asynchronously by [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and operate in the background, allowing the environment to query the status of a deployment operation at any time or to stop the operation, if necessary. The \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg*> interface deployment operations are called by the environment when the user selects the deploy command.  
  
 To notify the environment that a deployment operation has begun or ended, the project subtype needs to call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployStatusCallback.OnStartDeploy*> and the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployStatusCallback.OnEndDeploy*> methods.  
  
## Handling Specialized Deployment  
  
#### To handle a specialized deployment by a subtype project  
  
-   Implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.AdviseDeployStatusCallback*> method to register the environment to receive notifications of deployment status events.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   Implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.UnadviseDeployStatusCallback*> method to cancel the environment's registration to receive notifications of deployment status events.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   Implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.Commit*> method to perform the commit operation specific to your application.  This method is used mainly for database deployment.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
-   Implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.Rollback*> method to perform a rollback operation. When this method is called, the deployment project must do whatever is appropriate to rollback changes and restore the state of the project. This method is used mainly for database deployment.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
-   Implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.QueryStartDeploy*> method to determine whether or not a project is able to start a deployment operation.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
-   Implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.QueryStatusDeploy*> method to determine whether or not a deployment operation has completed successfully.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
-   Implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.StartDeploy*> method to begin a deployment operation in a separate thread. Place the code specific to your application's deployment inside the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
-   Implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg.StopDeploy*> method to stop a deployment operation. This method is called when a user presses the **Cancel** button during the deployment process.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
> [!NOTE]
>  All code examples provided in this topic are parts of a larger example, [Visual Studio Extensibility Samples](../vs140/vssdk-samples.md).  
  
## See Also  
 [Project Subtypes](../vs140/project-subtypes.md)