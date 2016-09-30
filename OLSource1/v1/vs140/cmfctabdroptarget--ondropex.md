---
title: "CMFCTabDropTarget::OnDropEx"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CMFCTabDropTarget::OnDropEx"
  - "CMFCTabDropTarget.OnDropEx"
  - "OnDropEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDropEx method"
ms.assetid: 4c337872-abaf-4fda-82bb-a9b2ab89ed4b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabDropTarget::OnDropEx
Called by the framework when the user releases the mouse button at the end of a drag operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Unused.|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A pointer to the object that the user drags.|  
|[in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The default drop operation.|  
|[in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Unused.|  
|[in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The location of the mouse pointer in client coordinates.|  
  
## Return Value  
 The resulting drop effect. It can be one or more of the following:  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Remarks  
 This method calls <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the toolbar framework is in customization mode and the Clipboard data format is available. If the call to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns a nonzero value, this method returns the default drop effect specified by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Otherwise, this method returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. For more information about drop effects, see [COleDropTarget::OnDropEx](../vs140/coledroptarget--ondropex.md).  
  
 For more information about customization mode, see [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar--iscustomizemode.md). For more information about Clipboard data formats, see [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCTabDropTarget Class](../vs140/cmfctabdroptarget-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [COleDropTarget::OnDropEx](../vs140/coledroptarget--ondropex.md)   
 [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar--iscustomizemode.md)   
 [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md)