---
title: "CMouseManager::AddView"
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
  - "CMouseManager::AddView"
  - "CMouseManager.AddView"
  - "AddView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddView method"
ms.assetid: 81a5f35e-a1c5-4186-9343-1caadfeccd02
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMouseManager::AddView
Registers a [CView](../vs140/cview-class.md) object with the [CMouseManager Class](../vs140/cmousemanager-class.md) to support custom mouse behavior.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A view ID.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A resource string ID that references the view name.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A view icon ID.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A view ID.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A view name.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 In order to support custom mouse behavior, a view must be registered with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. Any object derived from the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class can be registered with the mouse manager. The string and icon associated with a view are displayed in the **Mouse** tab of the **Customize** dialog box.  
  
 It is the responsibility of the programmer to create and maintain view IDs such as <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 For more information about how to provide custom mouse behavior, see [Keyboard and Mouse Customization](../vs140/keyboard-and-mouse-customization.md).  
  
## Example  
 The following example demonstrates how to retrieve a pointer to a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object by using the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method and the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class. This code snippet is part of the [State Collection sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_StateCollection#4](../vs140/codesnippet/CPP/cmousemanager--addview_1.cpp)]  
  
## Requirements  
 **Header:** afxmousemanager.h  
  
## See Also  
 [CMouseManager Class](../vs140/cmousemanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [Keyboard and Mouse Customization](../vs140/keyboard-and-mouse-customization.md)