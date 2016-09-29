---
title: "How to: Use Text Markers"
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
  - "editors [Visual Studio SDK], legacy - using text markers"
ms.assetid: 76eed51c-eecb-4579-823e-13df2f0526b9
caps.latest.revision: 17
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Text Markers
Text markers can be applied to edit a <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer*> object.  
  
## Procedures  
  
#### To apply text markers  
  
1.  Obtain an instance of the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextManager*> class.  
  
    > [!NOTE]
    >  The core editor automatically applies standard text markers to any document that it is editing, and it should not be necessary to apply standard text markers explicitly.  
  
2.  Obtain a marker type ID of the marker you are interested in by calling the [GetRegisteredMarkerTypeID](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextManager.GetRegisteredMarkerTypeID(System.Guid@,System.Int32@)?qualifyHint=False&autoUpgrade=True) method with the `GUID` of the text marker you wish to work with.  
  
    > [!NOTE]
    >  Do not use the `GUID` of the VSPackage or of the service that provides the text marker.  
  
3.  Use the marker type ID obtained by calling the assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextManager.GetRegisteredMarkerTypeID(System.Guid@,System.Int32@)?qualifyHint=False&autoUpgrade=True method as a parameter to call the [CreateLineMarker](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines.CreateLineMarker(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient,Microsoft.VisualStudio.TextManager.Interop.IVsTextLineMarker[])?qualifyHint=False&autoUpgrade=True) method or the [CreateStreamMarker](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextStream.CreateStreamMarker(System.Int32,System.Int32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient,Microsoft.VisualStudio.TextManager.Interop.IVsTextStreamMarker[])?qualifyHint=False&autoUpgrade=True) method to apply a text marker to a given region of text.  
  
#### To add features to text markers  
  
1.  It may be desirable to add additional features to a text marker, such as tool tips, a special context menu, or handler for special circumstances. To do so:  
  
2.  Create an object implementing the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient*> interface.  
  
3.  If additional functionality is desired, implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClientEx*>, and the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClientAdvanced*> interfaces on the same object that implements the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient*> interface.  
  
4.  Pass the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient*> interface that you create, to the call to the assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines.CreateLineMarker(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient,Microsoft.VisualStudio.TextManager.Interop.IVsTextLineMarker[])?qualifyHint=False&autoUpgrade=True method or the assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextStream.CreateStreamMarker(System.Int32,System.Int32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient,Microsoft.VisualStudio.TextManager.Interop.IVsTextStreamMarker[])?qualifyHint=False&autoUpgrade=True method used to apply the text marker to a given region of text.  
  
5.  When adding context menu support to a text marker region it is necessary to create the menu.  
  
     For more information on how to create a context menu see, [Context Menus](../vs140/context-menus.md).  
  
6.  The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment calls the methods of the supplied interfaces, such as the [GetTipText](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient.GetTipText(Microsoft.VisualStudio.TextManager.Interop.IVsTextMarker,System.String[])?qualifyHint=False&autoUpgrade=True) method, or the [ExecMarkerCommand](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerClient.ExecMarkerCommand(Microsoft.VisualStudio.TextManager.Interop.IVsTextMarker,System.Int32)?qualifyHint=False&autoUpgrade=True) method as needed.  
  
## See Also  
 [Text Markers in the Editor](../vs140/using-text-markers-with-the-legacy-api.md)   
 [How to: Add Standard Text Markers](../vs140/how-to--add-standard-text-markers.md)   
 [How To: Create a Custom Text Marker](../vs140/how-to--create-custom-text-markers.md)   
 [How to: Implement Error Markers](../vs140/how-to--implement-error-markers.md)