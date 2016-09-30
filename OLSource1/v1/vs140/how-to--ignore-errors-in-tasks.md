---
title: "How to: Ignore Errors in Tasks"
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
  - "MSBuild, ignoring errors"
  - "ContinueOnError attribute [MSBuild]"
ms.assetid: e2f1ca4f-787b-44bd-bc64-81a036025e96
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Ignore Errors in Tasks
Sometimes you want a build to be tolerant of faults in certain tasks. If those non-critical tasks fail, you want the build to continue because it can still produce the required output. For example, if a project uses a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> task to send an e-mail message after each component is built, you might consider it acceptable for the build to proceed to completion even when the mail servers are unavailable and the status messages cannot be sent. Or, for example, if intermediate files are usually deleted during the build, you might consider it acceptable for the build to proceed to completion even when those files cannot be deleted.  
  
## Using the ContinueOnError Attribute  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element controls whether a build stops or continues when a task failure occurs. This attribute also controls whether errors are treated as errors or warnings when the build continues.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute can contain one of the following values:  
  
-   **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../vs140/target-element--msbuild-.md) element and the build continue to execute, and all errors from the task are treated as warnings.  
  
-   **ErrorAndContinue**. When a task fails, subsequent tasks in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element and the build continue to execute, and all errors from the task are treated as errors.  
  
-   **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element and the build aren't executed, and the entire <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element and the build is considered to have failed.  
  
 Versions of the .NET Framework before 4.5 supported only the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> values.  
  
 The default value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If you set the attribute to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, you make the behavior explicit to anyone who reads the project file.  
  
#### To ignore an error in a task  
  
-   Use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> attribute of the task. For example:  
  
     <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Example  
 The following code example illustrates that the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> target still runs and the build is considered a success, even if the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> task fails.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild](../vs140/msbuild.md)   
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)