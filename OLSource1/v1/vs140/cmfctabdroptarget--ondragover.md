---
title: "CMFCTabDropTarget::OnDragOver"
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
  - "OnDragOver"
  - "CMFCTabDropTarget.OnDragOver"
  - "CMFCTabDropTarget::OnDragOver"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDragOver method"
ms.assetid: 21d9962a-d713-4488-bc82-5b3cc30e6cbd
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabDropTarget::OnDragOver
Called by the framework when the user drags an object onto the tab window that has focus.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Unused.|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A pointer to the object that the user drags.|  
|[in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Contains the state of the modifier keys. This is a combination of any number of the following: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|[in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The location of the mouse pointer in client coordinates.|  
  
## Return Value  
 The effect that results if the drop occurs at the location specified by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. It can be one or more of the following:  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
## Remarks  
 This method makes the tab that is under the cursor when a drag operation occurs active. It returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> if the toolbar framework is not in customization mode or the Clipboard data format is unavailable. Otherwise, it returns the result of calling <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> with the provided parameters.  
  
 For more information about customization mode, see [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar--iscustomizemode.md). For more information about Clipboard data formats, see [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCTabDropTarget Class](../vs140/cmfctabdroptarget-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [COleDataObject::IsDataAvailable](../vs140/coledataobject--isdataavailable.md)