---
title: "Renaming Project Hierarchy Nodes (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "HierUtil7 sample [Visual Studio SDK], renaming project nodes"
  - "project nodes, renaming in HierUtil7 sample"
ms.assetid: cea5968e-e9f8-41a5-b068-622df542247c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Renaming Project Hierarchy Nodes (C++)
You can rename a project folder hierarchy node by using the HierUtil7 project framework for unmanaged C++. For more information, see [HierUtil7 Sample](assetId:///29c15184-a70c-4813-86c2-fb1d47442d11).  
  
## Expanding the Hierarchy node  
  
#### To expand the hierarchy node and rename the folder  
  
1.  Select the hierarchy node by using the following method:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the hierarchy container corresponding to the folder and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is from the \<xref:Microsoft.VisualStudio.Shell.Interop.EXPANDFLAGS*> enumeration. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a GUID constant defined in Vsshell.idl and is an example for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the function signature of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, defined in Hu_node.h.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     You can find the Hu_node.h file in the folder, \<installation root>\Program Files\VSIP 8.0\EnvSDK\common\hierutil7:  
  
2.  Rename the folder by posting the rename command by using \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.PostExecCommand*>  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell*> pointer: <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a unique identifier of the command group to which the command <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> belongs, defined in Vsshlids.h.  
  
## See Also  
 [Project Types Overview](../vs140/creating-project-types.md)   
 [Visual Studio Extensibility Samples](../vs140/vssdk-samples.md)