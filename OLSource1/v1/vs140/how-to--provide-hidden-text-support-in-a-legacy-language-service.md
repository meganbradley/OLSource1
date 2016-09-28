---
title: "How to: Provide Hidden Text Support in a Legacy Language Service"
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
  - "hidden text, supporting"
  - "editors [Visual Studio SDK], hidden text"
  - "language services, implementing hidden text regions"
ms.assetid: 1c1dce9f-bbe2-4fc3-a736-5f78a237f4cc
caps.latest.revision: 25
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Provide Hidden Text Support in a Legacy Language Service
You can create hidden text regions in addition to outline regions. Hidden text regions can be client-controlled or editor-controlled and are used to hide a region of text completely. The editor displays a hidden region as horizontal lines. An example of this is the Script Only view in the HTML editor.  
  
## Procedure  
  
#### To implement a hidden text region  
  
1.  Call `QueryService` for <xref:Microsoft.VisualStudio.TextManager.Interop.SVsTextManager*>.  
  
     This returns a pointer to <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextManager*>.  
  
2.  Call [GetHiddenTextSession](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextManager.GetHiddenTextSession(System.Object,Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession@)?qualifyHint=False&autoUpgrade=True), passing in a pointer for a given text buffer. This determines whether a hidden text session already exists for the buffer.  
  
3.  If one already exists, then you do not need to create one and a pointer to the existing <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession*> object is returned. Use this pointer to enumerate and create hidden text regions. Otherwise, call [CreateHiddenTextSession](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextManager.CreateHiddenTextSession(System.UInt32,System.Object,Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextClient,Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession@)?qualifyHint=False&autoUpgrade=True) to create a hidden text session for the buffer.  
  
     A pointer to the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession*> object is returned.  
  
    > [!NOTE]
    >  When you call `CreateHiddenTextSession`, you can specify a hidden text client (that is, <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextClient*>). The hidden text client notifies you when hidden text or outlining is expanded or collapsed by the user.  
  
4.  Call [AddHiddenRegions](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession.AddHiddenRegions(System.UInt32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.NewHiddenRegion[],Microsoft.VisualStudio.TextManager.Interop.IVsEnumHiddenRegions[])?qualifyHint=False&autoUpgrade=True) to add one or more new outline regions at a time, specifying the following information in the `reHidReg` (<xref:Microsoft.VisualStudio.TextManager.Interop.NewHiddenRegion*>) parameter:  
  
    1.  Specify a value of `hrtConcealed` in the `iType` member of the <xref:Microsoft.VisualStudio.TextManager.Interop.NewHiddenRegion*> structure to indicate that you are creating a hidden region, rather than an outline region.  
  
        > [!NOTE]
        >  When concealed regions are hidden, the editor automatically displays lines around the hidden regions to indicate their presence.  
  
    2.  Specify whether the region is client-controlled or editor-controlled in the `dwBehavior` members of the <xref:Microsoft.VisualStudio.TextManager.Interop.NewHiddenRegion*> structure. Your smart outlining implementation can contain a mix of editor- and client-controlled outline and hidden text regions.