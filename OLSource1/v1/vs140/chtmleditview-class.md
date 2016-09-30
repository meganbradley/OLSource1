---
title: "CHtmlEditView Class"
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
  - "CHtmlEditView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlEditView class"
ms.assetid: 166c8ba8-3fb5-4dd7-a9ea-5bca662d00f6
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditView Class
Provides the functionality of the WebBrowser editing platform within the context of MFC's document/view architecture.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CHtmlEditView::CHtmlEditView](#chtmleditview__chtmleditview)|Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CHtmlEditView::Create](#chtmleditview__create)|Creates a new window object.|  
|[CHtmlEditView::GetDHtmlDocument](#chtmleditview__getdhtmldocument)|Returns the **IHTMLDocument2** interface on the current document.|  
|[CHtmlEditView::GetStartDocument](#chtmleditview__getstartdocument)|Retrieves the name of the default document for this view.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CView](../vs140/cview-class.md)  
  
 [CScrollView](../vs140/cscrollview-class.md)  
  
 [CFormView](../vs140/cformview-class.md)  
  
 [CHtmlEditCtrlBase](../vs140/chtmleditctrlbase-class.md)  
  
 [CHtmlView](../vs140/chtmlview-class.md)  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxhtml.h  
  
##  \<a name="chtmleditview__chtmleditview">\</a>  CHtmlEditView::CHtmlEditView  
 Constructs a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="chtmleditview__create">\</a>  CHtmlEditView::Create  
 Creates a new window object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Points to a null-terminated character string that names the Windows class. The class name can be any name registered with the [AfxRegisterWndClass](../vs140/afxregisterwndclass.md) global function or the **RegisterClass** Windows function. If **NULL**, uses the predefined default [CFrameWnd](../vs140/cframewnd-class.md) attributes.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Points to a null-terminated character string that represents the window name.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the window style attributes. By default, the **WS_VISIBLE** and **WS_CHILD** Windows styles are set.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the size and position of the window. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> value allows Windows to specify the size and position of the new window.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A pointer to the parent window of the control.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The ID number of the view. By default, set to **AFX_IDW_PANE_FIRST**.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A pointer to a [CCreateContext](../vs140/ccreatecontext-structure.md). **NULL** by default.  
  
### Remarks  
 This method will also call the contained WebBrowser's **Navigate** method to load a default document (see [CHtmlEditView::GetStartDocument](#chtmleditview__getstartdocument)).  
  
##  \<a name="chtmleditview__getdhtmldocument">\</a>  CHtmlEditView::GetDHtmlDocument  
 Returns the **IHTMLDocument2** interface on the current document.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The                                 [IHTMLDocument2](https://msdn.microsoft.com/en-us/library/aa752574.aspx) interface.  
  
##  \<a name="chtmleditview__getstartdocument">\</a>  CHtmlEditView::GetStartDocument  
 Retrieves the name of the default document for this view.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [HTMLEdit Sample](../vs140/visual-c---samples.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)