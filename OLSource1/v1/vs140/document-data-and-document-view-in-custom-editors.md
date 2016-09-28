---
title: "Document Data and Document View in Custom Editors"
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
  - "editors [Visual Studio SDK], custom - document data and document view"
ms.assetid: 71eea623-f566-4feb-84cd-ca1ba71bc493
caps.latest.revision: 27
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Document Data and Document View in Custom Editors
A custom editor consists of two parts: a document data object and a document view object. As the names suggest, the document data object represents the text data to be displayed, and the document view object (or "view") represents one or more windows in which to display the document data object.  
  
## Document Data Object  
 A document data object is a data representation of text in the text buffer. It is a COM object that stores document text and other information, handles document persistence, and enables multiple views of its data. For more information, see  
  
 [DocumentData](assetId:///P:EnvDTE80.Window2.DocumentData(System.String)?qualifyHint=False&autoUpgrade=True) and [Document Windows](../vs140/document-windows.md).  
  
 Custom editors and designers can opt to use the <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer*> object or their own custom buffer. <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer*> follows the simplified embedding model for a standard editor, supports multiple views, and provides event interfaces that are used to manage multiple views.  
  
## Document View Object  
 A window that displays code and other text is known as a document view or view. When you create an editor, you can choose either a single view, in which text is displayed in a single window, or a multiple view, in which text is displayed in more than one window. Your choice depends on your application. For example, if you need side-by-side editing, you would choose multiple view. Each view is associated with an entry in the integrated development environment's (IDE) running document table (RDT). View windows belong to a project or an <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy*> object.  
  
 If your editor supports multiple views of a document data object, then your document data and document view objects must be separate. Otherwise, they can be grouped together. For more information, see [Supporting Multiple Document Views](../vs140/supporting-multiple-document-views.md).  
  
 The IDE notifies views about events (for example, when a solution containing a document is closed) by matching an item identifier (ItemID) for each entry in the running document table. For more information on this, see [Running Document Table](../vs140/running-document-table.md).  
  
 There are two options for creating a view for a custom editor. One is the in-place activation model, where the view is hosted in a window using either an ActiveX control or a document data object. The second is the simplified embedding model, where the view is hosted by [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowPane*> is implemented to handle window commands. For information about the in-place activation model, see [In-Place Activation Editors](../vs140/in-place-activation.md). For information about the simplified embedding model, see [Simplified Embedding Editors](../vs140/simplified-embedding.md).  
  
## See Also  
 [Supporting Multiple Document Views](../vs140/supporting-multiple-document-views.md)   
 [Simplified Embedding](../vs140/simplified-embedding.md)   
 [How to: Attach Views to Document Data Objects](../vs140/how-to--attach-views-to-document-data.md)   
 [Document Lock Holder Management](../vs140/document-lock-holder-management.md)   
 [Single and Multi-tab Views](../vs140/single-and-multi-tab-views.md)   
 [Saving a Standard Document](../vs140/saving-a-standard-document.md)   
 [Persistence and the Running Document Table](../vs140/persistence-and-the-running-document-table.md)   
 [Determining Which Editor Opens a File in a Project](../vs140/determining-which-editor-opens-a-file-in-a-project.md)   
 [Editor Factories](../vs140/editor-factories.md)