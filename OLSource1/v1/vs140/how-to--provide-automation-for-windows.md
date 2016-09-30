---
title: "How to: Provide Automation for Windows"
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
  - "automation [Visual Studio SDK], tool windows"
  - "tool windows, automation"
ms.assetid: 512ab2a4-7987-4912-8f40-8804bf66f829
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Provide Automation for Windows
You can provide automation for document and tool windows. Providing automation is advisable whenever you want to make automation objects available on a window, and the environment does not already provide a ready-made automation object, as it does with a task list.  
  
## Automation for Tool Windows  
 The environment provides automation on a tool window by returning a standard \<xref:EnvDTE.Window*> object as explained in the following procedure:  
  
#### To provide automation for tool windows  
  
1.  Call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.GetProperty*> method via the environment with \<xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID.VSFPROPID_ExtWindowObject*> as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> parameter to get the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
2.  When a caller requests a VSPackage-specific automation object for your tool window through \<xref:EnvDTE.Window.Object*>, the environment calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, \<xref:Microsoft.VisualStudio.Shell.Interop.IVsExtensibleObject*>, or the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interfaces. Both <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> provide a \<xref:Microsoft.VisualStudio.Shell.Interop.IVsExtensibleObject.GetAutomationObject*> method.  
  
3.  When the environment then calls the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method passing <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, respond by passing back your VSPackage-specific object.  
  
4.  If calling <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> fails, then the environment calls <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Automation for Document Windows  
 A standard \<xref:EnvDTE.Document*> object is also available from the environment, although an editor can have its own implementation of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object by implementing <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> interface and responding to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 In addition, an editor can provide a VSPackage-specific automation object, retrieved through the \<xref:EnvDTE.Document.Object*> method, by implementing the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interfaces. The [Basic Edit sample](../vs140/vssdk-samples.md) contributes an RTF document-specific automation object.  
  
## See Also  
 \<xref:Microsoft.VisualStudio.Shell.Interop.IVsExtensibleObject*>