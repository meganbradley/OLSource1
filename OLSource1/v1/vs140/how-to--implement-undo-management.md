---
title: "How to: Implement Undo Management"
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
  - "editors [Visual Studio SDK], legacy - undo management"
ms.assetid: 1942245d-7a1d-4a11-b5e7-a3fe29f11c0b
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Implement Undo Management
The primary interface used for undo management is \<xref:Microsoft.VisualStudio.OLE.Interop.IOleUndoManager*>, which is implemented by the environment. To support undo management, implement separate undo units (that is, \<xref:Microsoft.VisualStudio.OLE.Interop.IOleUndoUnit*>, which can contain multiple individual steps.  
  
 How you implement undo management varies depending on whether your editor supports multiple views or not. The procedures for each implementation are detailed in the following sections.  
  
## Cases where an editor supports a single view  
 In this scenario, the editor does not support multiple views. There is only one editor and one document, and they support undo. Use the following procedure to implement undo management.  
  
#### To support undo management for a single-view editor  
  
1.  Call <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> on the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface on the window frame for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, from the document view object to access the undo manager (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
2.  When a view is sited into a window frame, it gets a site pointer, which it can use to call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Cases where an editor supports multiple views  
 If you have document and view separation, then there is normally one undo manager associated with the document itself. All undo units are placed on one undo manager associated with the document data object.  
  
 Instead of the view querying for the undo manager, of which there is one for each view, the document data object calls \<xref:Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2.CreateInstance*> to instantiate the undo manager, specifying a class identifier of CLSID_OLEUndoManager. The class identifier is defined in the OCUNDOID.h file.  
  
 When using \<xref:Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2.CreateInstance*> to create your own undo manager instance, use the following procedure to hook your undo manager into the environment.  
  
#### To hook your undo manager into the environment  
  
1.  Call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on the object returned from \<xref:Microsoft.VisualStudio.Shell.Interop.ILocalRegistry2*> for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Store the pointer to \<xref:Microsoft.VisualStudio.OLE.Interop.IOleUndoManager*>.  
  
2.  Call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> on <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Store the pointer to \<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget*>.  
  
3.  Relay your \<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus*> and \<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec*> calls into the stored <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface for the following StandardCommandSet97 commands:  
  
    -   cmdidUndo  
  
    -   cmdidMultiLevelUndo  
  
    -   cmdidRedo  
  
    -   cmdidMultiLevelRedo  
  
    -   cmdidMultiLevelUndoList  
  
    -   cmdidMultiLevelRedoList  
  
4.  Call <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> on <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Store the pointer to \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsChangeTrackingUndoManager*>.  
  
     Use the pointer to \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsChangeTrackingUndoManager*> to call the \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsChangeTrackingUndoManager.MarkCleanState*>, the \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsChangeTrackingUndoManager.AdviseTrackingClient*>, and the \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsChangeTrackingUndoManager.UnadviseTrackingClient*> methods.  
  
5.  Call <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> on <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
6.  Call \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsLinkCapableUndoManager.AdviseLinkedUndoClient*> with your document, which should also implement the \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsLinkedUndoClient*> interface. When your document is closed, call <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
7.  When your document is closed, call <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> on your undo manager for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
8.  Call \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsLifetimeControlledObject.SeverReferencesToOwner*>.  
  
9. When changes are made to the document, call \<xref:Microsoft.VisualStudio.OLE.Interop.IOleUndoManager.Add*> on the manager with an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class. The \<xref:Microsoft.VisualStudio.OLE.Interop.IOleUndoManager.Add*> method keeps a reference to the object, so generally you release it right after the \<xref:Microsoft.VisualStudio.OLE.Interop.IOleUndoManager.Add*>.  
  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class represents a single undo stack instance. Thus, there is one undo manager object per data entity being tracked for undo or redo.  
  
> [!NOTE]
>  While the undo manager object is used extensively by the text editor, it is a general component that has no specific support for the text editor. If you want to support multi-level undo or redo, you can use this object to do so.  
  
## See Also  
 \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsChangeTrackingUndoManager*>   
 \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsLifetimeControlledObject*>   
 [How to: Clear the Undo Stack](../vs140/how-to--clear-the-undo-stack.md)