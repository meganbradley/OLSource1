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
With [CRichEditView](../VS_csharp/cricheditview-class.md) and [CRichEditCntrItem](../VS_csharp/cricheditcntritem-class.md), provides the functionality of the rich edit control within the context of MFC's document view architecture.  
  
## Syntax  
  
```  
class CRichEditDoc : public COleServerDoc  
  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRichEditDoc::CreateClientItem](#cricheditdoc__createclientitem)|Called to perform cleanup of the document.|  
|[CRichEditDoc::GetStreamFormat](#cricheditdoc__getstreamformat)|Indicates whether stream input and output should include formatting information.|  
|[CRichEditDoc::GetView](#cricheditdoc__getview)|Retrieves the asssociated [CRichEditView](../VS_csharp/cricheditview-class.md) object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CRichEditDoc::m_bRTF](#cricheditdoc__m_brtf)|Indicates whether stream I/O should include formatting.|  
  
## Remarks  
 A "rich edit control" is a window in which the user can enter and edit text. The text can be assigned character and paragraph formatting, and can include embedded OLE objects. Rich edit controls provide a programming interface for formatting text. However, an application must implement any user interface components necessary to make formatting operations available to the user.  
  
 `CRichEditView` maintains the text and formatting characteristic of text. `CRichEditDoc` maintains the list of client items which are in the view. `CRichEditCntrItem` provides container-side access to the OLE client items.  
  
 This Windows Common control (and therefore the [CRichEditCtrl](../VS_csharp/cricheditctrl-class.md) and related classes) is available only to programs running under Windows 95/98 and Windows NT versions 3.51 and later.  
  
 For an example of using a rich edit document in an MFC application, see the [WORDPAD](../VS_csharp/visual-c---samples.md) sample application.  
  
## Inheritance Hierarchy  
 [CObject](../VS_csharp/cobject-class.md)  
  
 [CCmdTarget](../VS_csharp/ccmdtarget-class.md)  
  
 [CDocument](../VS_csharp/cdocument-class.md)  
  
 [COleDocument](../VS_csharp/coledocument-class.md)  
  
 [COleLinkingDoc](../VS_csharp/colelinkingdoc-class.md)  
  
 [COleServerDoc](../VS_csharp/coleserverdoc-class.md)  
  
 `CRichEditDoc`  
  
## Requirements  
 **Header:** afxrich.h  
  
##  <a name="cricheditdoc__createclientitem"></a>  CRichEditDoc::CreateClientItem  
 Call this function to create a `CRichEditCntrItem` object and add it to this document.  
  
```  
virtual CRichEditCntrItem* CreateClientItem(    REOBJECT*  preo  = NULL  ) const = 0;  
  
```  
  
### Parameters  
 *preo*  
 Pointer to an                                 [REOBJECT](http://msdn.microsoft.com/library/windows/desktop/bb787946) structure which describes an OLE item. The new `CRichEditCntrItem` object is constructed around this OLE item. If                                 *preo* is **NULL**, the new client item is empty.  
  
### Return Value  
 Pointer to a new [CRichEditCntrItem](../VS_csharp/cricheditcntritem-class.md) object which has been added to this document.  
  
### Remarks  
 This function does not perform any OLE initialization.  
  
 For more information, see the                         [REOBJECT](http://msdn.microsoft.com/library/windows/desktop/bb787946) structure in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
##  <a name="cricheditdoc__getstreamformat"></a>  CRichEditDoc::GetStreamFormat  
 Call this function to determine the text format for streaming the contents of the rich edit.  
  
```  
int GetStreamFormat( ) const;  
  
```  
  
### Return Value  
 One of the following flags:  
  
-   `SF_TEXT` Indicates that the rich edit control does not maintain formatting information.  
  
-   `SF_RTF` Indicates that the rich edit control does maintain formatting information.  
  
### Remarks  
 The return value is based on the [m_bRTF](#cricheditdoc__m_brtf) data member. This function returns `SF_RTF` if `m_bRTF` is **TRUE**; otherwise, `SF_TEXT`.  
  
##  <a name="cricheditdoc__getview"></a>  CRichEditDoc::GetView  
 Call this function to access the [CRichEditView](../VS_csharp/cricheditview-class.md) object associated with this `CRichEditDoc` object.  
  
```  
virtual CRichEditView* GetView( ) const;  
  
```  
  
### Return Value  
 Pointer to the `CRichEditView` object associated with the document.  
  
### Remarks  
 The text and formatting information are contained within the `CRichEditView` object. The `CRichEditDoc` object maintains the OLE items for serialization. There should be only one `CRichEditView` for each `CRichEditDoc`.  
  
##  <a name="cricheditdoc__m_brtf"></a>  CRichEditDoc::m_bRTF  
 When **TRUE**, indicates that [CRichEditCtrl::StreamIn](../VS_csharp/cricheditctrl-class.md#cricheditctrl__streamin) and [CRichEditCtrl::StreamOut](../VS_csharp/cricheditctrl-class.md#cricheditctrl__streamout) should store paragraph and character-formatting characteristics.  
  
```  
BOOL m_bRTF;  
  
```  
  
## See Also  
 [MFC Sample WORDPAD](../VS_csharp/visual-c---samples.md)   
 [Base Class](../VS_csharp/coleserverdoc-class.md)   
 [Hierarchy Chart](../VS_csharp/hierarchy-chart.md)   
 [CRichEditView](../VS_csharp/cricheditview-class.md)   
 [CRichEditCntrItem](../VS_csharp/cricheditcntritem-class.md)   
 [COleDocument](../VS_csharp/coledocument-class.md)   
 [CRichEditCtrl](../VS_csharp/cricheditctrl-class.md)