---
title: "How to: Provide Context for Editors"
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
  - "editors [Visual Studio SDK], legacy - provide context"
ms.assetid: 12df4d06-df6b-4eaf-a7bf-c83655a0c683
caps.latest.revision: 21
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Provide Context for Editors
For an editor, the context is active only when the editor has focus or had focus immediately before the focus was moved to a tool window. You can provide context for an editor by doing the following:  
  
1.  Create a context bag.  
  
2.  Publish the context bag to the selection element identifier (SEID).  
  
3.  Maintain the context in the bag.  
  
 These tasks are covered by the following procedures. For more information about providing context, see **Robust Programming** later in this topic.  
  
### To create a context bag for an editor or a designer  
  
1.  Call `QueryService` on your <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider*> interface for the <xref:Microsoft.VisualStudio.Shell.Interop.SVsMonitorUserContext*> service.  
  
     A pointer to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorUserContext*> interface is returned.  
  
2.  Call the [CreateEmptyContext](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsMonitorUserContext.CreateEmptyContext(Microsoft.VisualStudio.Shell.Interop.IVsUserContext@)?qualifyHint=False&autoUpgrade=True) method to create a new context or subcontext bag.  
  
     A pointer to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext*> interface is returned.  
  
3.  Call the [AddAttribute](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AddAttribute(Microsoft.VisualStudio.Shell.Interop.VSUSERCONTEXTATTRIBUTEUSAGE,System.String,System.String)?qualifyHint=False&autoUpgrade=True) method to add attributes, lookup keywords, or F1 keywords to the context or subcontext bag.  
  
4.  If you are creating a subcontext bag, call the [AddSubcontext](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AddSubcontext(Microsoft.VisualStudio.Shell.Interop.IVsUserContext,System.Int32,System.UInt32@)?qualifyHint=False&autoUpgrade=True) method to link the subcontext bag to the parent context bag.  
  
5.  Call [AdviseUpdate](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AdviseUpdate(Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate,System.UInt32@)?qualifyHint=False&autoUpgrade=True) to receive notification when the **Dynamic Help** window is about to update.  
  
     Having the **Dynamic Help** window call your editor when it is ready to update gives you the opportunity to delay changing the context until the update occurs. Doing this can improve performance because it allows you to delay running time-consuming algorithms until system idle time is available.  
  
### To publish the context bag to the SEID  
  
1.  Call `QueryService` on the <xref:Microsoft.VisualStudio.Shell.Interop.SVsTrackSelectionEx*> service to return a pointer to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx*> interface.  
  
2.  Call [OnElementValueChange](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx.OnElementValueChange(System.UInt32,System.Int32,System.Object)?qualifyHint=False&autoUpgrade=True), specifying an element identifier (`elementid` parameter) value of SEID_UserContext to indicate that you are passing context to the global level.  
  
3.  When the editor or designer becomes active, the values in its <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx*> object are propagated to the global selection. You only need to complete this process once per session, and then store the pointer to the global context created when you called assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx.OnElementValueChange(System.UInt32,System.Int32,System.Object)?qualifyHint=False&autoUpgrade=True.  
  
### To maintain the context bag  
  
1.  Implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContext*> to ensure that the **Dynamic Help** window calls the editor or designer before it updates.  
  
     For each context bag that has called assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AdviseUpdate(Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate,System.UInt32@)?qualifyHint=False&autoUpgrade=True after the context bag is created and has implemented <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate*>, the IDE calls [UpdateUserContext](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate.UpdateUserContext(Microsoft.VisualStudio.Shell.Interop.IVsUserContext,System.UInt32)?qualifyHint=False&autoUpgrade=True) to notify the context provider that the context bag will be updated. You can use this call to change the attributes and keywords in the context bag, and in any subcontext bags, before the **Dynamic Help** window update occurs.  
  
2.  Call [SetDirty](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.SetDirty(System.Int32)?qualifyHint=False&autoUpgrade=True) on the context bag to indicate that the editor or designer has new context.  
  
     When the **Dynamic Help** window calls assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate.UpdateUserContext(Microsoft.VisualStudio.Shell.Interop.IVsUserContext,System.UInt32)?qualifyHint=False&autoUpgrade=True to indicate that it is updating, the editor or designer can update the context appropriately for both the parent context bag and any subcontext bags at that time.  
  
    > [!NOTE]
    >  The `SetDirty` flag is automatically set to `true` whenever context is added or removed from the context bag. The **Dynamic Help** window only calls assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate.UpdateUserContext(Microsoft.VisualStudio.Shell.Interop.IVsUserContext,System.UInt32)?qualifyHint=False&autoUpgrade=True on the context bag if the `SetDirty` flag is set to `true`. It is reset to `false` after the update.  
  
3.  Call assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AddAttribute(Microsoft.VisualStudio.Shell.Interop.VSUSERCONTEXTATTRIBUTEUSAGE,System.String,System.String)?qualifyHint=False&autoUpgrade=True to add context to the active context collection or [RemoveAttribute](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.RemoveAttribute(System.String,System.String)?qualifyHint=False&autoUpgrade=True) to remove context.  
  
## Robust Programming  
 If you are writing your own editor, then you must complete all three of the procedures in this topic to provide context for the editor.  
  
> [!NOTE]
>  To properly activate an editor or designer window and to ensure that command routing is updated properly, you must call <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.Show*> on the component to make it the focus window.  
  
 The SEID is a collection of properties that change based on the selection. SEID information is available through the global selection. The global selection is wired into events triggered by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx*> interface, and has a list of everything that is selected (current editor, current tool window, current hierarchy, and so on).  
  
 For editors and designers, in which context can change whenever the cursor moves within a word, it is inefficient to constantly update the context bag. To make updating more efficient any time you detect the cursor moving within the editor or designer window, you can call assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.SetDirty(System.Int32)?qualifyHint=False&autoUpgrade=True. Doing this allows you to hold your context changes until there is idle time and the IDE's context service sends notification to the editor or designer that the **Dynamic Help** window is updating. This approach is used in the "To maintain the context bag" procedure in this topic.  
  
 After providing context for activities within your editor or designer, you should provide a specific F1 keyword to allow users to get help for the editor or designer itself.  
  
## See Also  
 assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsTrackSelectionEx.OnElementValueChange(System.UInt32,System.Int32,System.Object)?qualifyHint=False&autoUpgrade=True   
 assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AddAttribute(Microsoft.VisualStudio.Shell.Interop.VSUSERCONTEXTATTRIBUTEUSAGE,System.String,System.String)?qualifyHint=False&autoUpgrade=True   
 assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.AdviseUpdate(Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate,System.UInt32@)?qualifyHint=False&autoUpgrade=True   
 assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.RemoveAttribute(System.String,System.String)?qualifyHint=False&autoUpgrade=True   
 assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContext.SetDirty(System.Int32)?qualifyHint=False&autoUpgrade=True   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate*>   
 assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUserContextUpdate.UpdateUserContext(Microsoft.VisualStudio.Shell.Interop.IVsUserContext,System.UInt32)?qualifyHint=False&autoUpgrade=True   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.Show*>   
 <xref:Microsoft.VisualStudio.Shell.Interop.SVsTrackSelectionEx*>