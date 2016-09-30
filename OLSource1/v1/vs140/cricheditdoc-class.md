---
title: "CRichEditDoc Class"
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
  - "CRichEditDoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "document/view architecture, rich edit controls"
  - "OLE containers, rich edit"
  - "documents, rich edit"
  - "rich edit controls, OLE container"
  - "CRichEditDoc class"
ms.assetid: c936ec18-d516-49d4-b7fb-c9aa0229eddc
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditDoc Class
With [CRichEditView](../vs140/cricheditview-class.md) and [CRichEditCntrItem](../vs140/cricheditcntritem-class.md), provides the functionality of the rich edit control within the context of MFC's document view architecture.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRichEditDoc::CreateClientItem](#cricheditdoc__createclientitem)|Called to perform cleanup of the document.|  
|[CRichEditDoc::GetStreamFormat](#cricheditdoc__getstreamformat)|Indicates whether stream input and output should include formatting information.|  
|[CRichEditDoc::GetView](#cricheditdoc__getview)|Retrieves the asssociated [CRichEditView](../vs140/cricheditview-class.md) object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CRichEditDoc::m_bRTF](#cricheditdoc__m_brtf)|Indicates whether stream I/O should include formatting.|  
  
## Remarks  
 A "rich edit control" is a window in which the user can enter and edit text. The text can be assigned character and paragraph formatting, and can include embedded OLE objects. Rich edit controls provide a programming interface for formatting text. However, an application must implement any user interface components necessary to make formatting operations available to the user.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> maintains the text and formatting characteristic of text. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> maintains the list of client items which are in the view. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> provides container-side access to the OLE client items.  
  
 This Windows Common control (and therefore the [CRichEditCtrl](../vs140/cricheditctrl-class.md) and related classes) is available only to programs running under Windows 95/98 and Windows NT versions 3.51 and later.  
  
 For an example of using a rich edit document in an MFC application, see the [WORDPAD](../vs140/visual-c---samples.md) sample application.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CDocument](../vs140/cdocument-class.md)  
  
 [COleDocument](../vs140/coledocument-class.md)  
  
 [COleLinkingDoc](../vs140/colelinkingdoc-class.md)  
  
 [COleServerDoc](../vs140/coleserverdoc-class.md)  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxrich.h  
  
##  \<a name="cricheditdoc__createclientitem">\</a>  CRichEditDoc::CreateClientItem  
 Call this function to create a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object and add it to this document.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *preo*  
 Pointer to an                                 [REOBJECT](http://msdn.microsoft.com/library/windows/desktop/bb787946) structure which describes an OLE item. The new <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is constructed around this OLE item. If                                 *preo* is **NULL**, the new client item is empty.  
  
### Return Value  
 Pointer to a new [CRichEditCntrItem](../vs140/cricheditcntritem-class.md) object which has been added to this document.  
  
### Remarks  
 This function does not perform any OLE initialization.  
  
 For more information, see the                         [REOBJECT](http://msdn.microsoft.com/library/windows/desktop/bb787946) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cricheditdoc__getstreamformat">\</a>  CRichEditDoc::GetStreamFormat  
 Call this function to determine the text format for streaming the contents of the rich edit.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 One of the following flags:  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> Indicates that the rich edit control does not maintain formatting information.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> Indicates that the rich edit control does maintain formatting information.  
  
### Remarks  
 The return value is based on the [m_bRTF](#cricheditdoc__m_brtf) data member. This function returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is **TRUE**; otherwise, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
##  \<a name="cricheditdoc__getview">\</a>  CRichEditDoc::GetView  
 Call this function to access the [CRichEditView](../vs140/cricheditview-class.md) object associated with this <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object associated with the document.  
  
### Remarks  
 The text and formatting information are contained within the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object maintains the OLE items for serialization. There should be only one <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> for each <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
##  \<a name="cricheditdoc__m_brtf">\</a>  CRichEditDoc::m_bRTF  
 When **TRUE**, indicates that [CRichEditCtrl::StreamIn](../vs140/cricheditctrl-class.md#cricheditctrl__streamin) and [CRichEditCtrl::StreamOut](../vs140/cricheditctrl-class.md#cricheditctrl__streamout) should store paragraph and character-formatting characteristics.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [MFC Sample WORDPAD](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView](../vs140/cricheditview-class.md)   
 [CRichEditCntrItem](../vs140/cricheditcntritem-class.md)   
 [COleDocument](../vs140/coledocument-class.md)   
 [CRichEditCtrl](../vs140/cricheditctrl-class.md)