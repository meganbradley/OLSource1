---
title: "Considerations for Unloading and Reloading Nested Projects"
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
  - "nested projects, unloading and reloading"
  - "projects [Visual Studio SDK], unloading and reloading nested"
ms.assetid: 06c3427e-c874-45b1-b9af-f68610ed016c
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Considerations for Unloading and Reloading Nested Projects
When you implement nested project types, you must perform additional steps when you unload and reload the projects. To correctly notify listeners to solution events, you must correctly raise the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> events.  
  
 One reason you must raise these events in this manner is that you do not want source code control (SCC) to delete the items from the server and then add them back as something new if there is a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operation from SCC. In that case, a new file would be loaded out of SCC and you have to unload and reload all the files in case they are different. SCC calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Your implementation of that call is to delete the project and re-create it again by implementing <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. When you perform this implementation, the SCC is informed that the project was temporarily deleted and added again. Therefore, the SCC does not operate on the project as if the project was actually deleted from the server and then added again.  
  
## Reloading Projects  
 To support reloading of nested projects, you implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem2.ReloadItem*> method. In your implementation of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, you close the nested projects and then re-create them.  
  
 Typically when a project is reloaded, the IDE raises the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnBeforeUnloadProject*> and the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> events. However, for nested projects that will be deleted and reloaded, the parent project initiates the process, not the IDE. Because the parent project does not raise solution events, and the IDE has no information about the initialization of the process, the events are not raised.  
  
 To handle this process, the parent project calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> on the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsFireSolutionEvents*> interface off the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution*> interface. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> has functions that tell the IDE to raise the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> event to unload the nested project, and then raise the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> event to reload the same project.  
  
## See Also  
 \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3*>   
 [Nesting Projects](../vs140/nesting-projects.md)