---
title: "Drag and Drop: Implementing a Drop Target"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE drag and drop, implementing drop targets"
  - "OLE drag and drop, drop target"
  - "drag and drop, drop target"
ms.assetid: 0689f1ec-5326-4008-b226-4b373c881358
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Drag and Drop: Implementing a Drop Target
This article outlines how to make your application a drop target. Implementing a drop target takes slightly more work than implementing a drop source, but it is still relatively simple. These techniques also apply to non-OLE applications.  
  
#### To implement a drop target  
  
1.  Add a member variable to each view in the application that you want to be a drop target. This member variable must be of type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or a class derived from it.  
  
2.  From your view class's function that handles the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> message (typically <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>), call the new member variable's <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will be called automatically for you when your view is destroyed.  
  
3.  Override the following functions. If you want the same behavior throughout your application, override these functions in your view class. If you want to modify behavior in isolated cases or want to enable dropping on non-<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> windows, override these functions in your <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-derived class.  
  
    |Override|To allow|  
    |--------------|--------------|  
    |<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Drop operations to occur in the window. Called when the cursor first enters the window.|  
    |<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Special behavior when the drag operation leaves the specified window.|  
    |<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Drop operations to occur in the window. Called when the cursor is being dragged across the window.|  
    |<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Handling of data being dropped into the specified window.|  
    |<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Special behavior for when scrolling is necessary in the target window.|  
  
 See the MAINVIEW.CPP file that is part of the MFC OLE sample [OCLIENT](../vs140/visual-c---samples.md) for an example of how these functions work together.  
  
 For more information, see:  
  
-   [Implementing a Drop Source](../vs140/drag-and-drop--implementing-a-drop-source.md)  
  
-   [Creating and Destroying OLE Data Objects and Data Sources](../vs140/data-objects-and-data-sources--creation-and-destruction.md)  
  
-   [Manipulating OLE Data Objects and Data Sources](../vs140/data-objects-and-data-sources--manipulation.md)  
  
## See Also  
 [Drag and Drop (OLE)](../vs140/drag-and-drop--ole-.md)   
 [COleDropTarget Class](../vs140/coledroptarget-class.md)