---
title: "Drawing in a View"
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
  - "drawing, in views"
  - "views, printing"
  - "views, updating"
  - "printing [MFC], views"
  - "views, rendering"
  - "printing views"
  - "paint messages in view class"
  - "device contexts, screen drawings"
ms.assetid: e3761db6-0f19-4482-a4cd-ac38ef7c4d3a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Drawing in a View
Nearly all drawing in your application occurs in the view's <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member function, which you must override in your view class. (The exception is mouse drawing, discussed in [Interpreting User Input Through a View](../vs140/interpreting-user-input-through-a-view.md).) Your <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> override:  
  
1.  Gets data by calling the document member functions you provide.  
  
2.  Displays the data by calling member functions of a device-context object that the framework passes to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 When a document's data changes in some way, the view must be redrawn to reflect the changes. Typically, this happens when the user makes a change through a view on the document. In this case, the view calls the document's [UpdateAllViews](../vs140/cdocument--updateallviews.md) member function to notify all views on the same document to update themselves. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> calls each view's [OnUpdate](../vs140/cview--onupdate.md) member function. The default implementation of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> invalidates the view's entire client area. You can override it to invalidate only those regions of the client area that map to the modified portions of the document.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function of class **CDocument** and the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function of class <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> let you pass information describing what parts of the document were modified. This "hint" mechanism lets you limit the area that the view must redraw. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> takes two "hint" arguments. The first, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, of type **LPARAM**, lets you pass any data you like, while the second, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>*, lets you pass a pointer to any object derived from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 When a view becomes invalid, Windows sends it a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> message. The view's [OnPaint](../vs140/cwnd--onpaint.md) handler function responds to the message by creating a device-context object of class [CPaintDC](../vs140/cpaintdc-class.md) and calls your view's <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> member function. You do not normally have to write an overriding <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> handler function.  
  
 A [device context](../vs140/device-contexts.md) is a Windows data structure that contains information about the drawing attributes of a device such as a display or a printer. All drawing calls are made through a device-context object. For drawing on the screen, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is passed a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object. For drawing on a printer, it is passed a [CDC](../vs140/cdc-class.md) object set up for the current printer.  
  
 Your code for drawing in the view first retrieves a pointer to the document, then makes drawing calls through the device context. The following simple <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> example illustrates the process:  
  
 [!code[NVC_MFCDocView#1](../vs140/codesnippet/CPP/drawing-in-a-view_1.cpp)]  
  
 In this example, you would define the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function as a member of your derived document class.  
  
 The example prints whatever string it gets from the document, centered in the view. If the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> call is for screen drawing, the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object passed in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> whose constructor has already called <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. Calls to drawing functions are made through the device-context pointer. For information about device contexts and drawing calls, see class [CDC](../vs140/cdc-class.md) in the *MFC Reference* and [Working with Window Objects](../vs140/working-with-window-objects.md).  
  
 For more examples of how to write <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, see the [MFC Samples](../vs140/visual-c---samples.md).  
  
## See Also  
 [Using Views](../vs140/using-views.md)