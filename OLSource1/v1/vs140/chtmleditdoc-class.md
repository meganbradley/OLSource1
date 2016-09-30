---
title: "CHtmlEditDoc Class"
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
  - "CHtmlEditDoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlEditDoc class"
ms.assetid: b2cca61f-e5d6-4099-b0d1-46bf85f0bd64
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditDoc Class
With [CHtmlEditView](../vs140/chtmleditview-class.md), provides the functionality of the WebBrowser editing platform within the context of the MFC document-view architecture.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CHtmlEditDoc::CHtmlEditDoc](#chtmleditdoc__chtmleditdoc)|Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CHtmlEditDoc::GetView](#chtmleditdoc__getview)|Retrieves the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object attached to this document.|  
|[CHtmlEditDoc::IsModified](#chtmleditdoc__ismodified)|Returns whether the associated view's WebBrowser control contains a document that has been modified by the user.|  
|[CHtmlEditDoc::OpenURL](#chtmleditdoc__openurl)|Opens a URL.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CDocument](../vs140/cdocument-class.md)  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxhtml.h  
  
##  \<a name="chtmleditdoc__chtmleditdoc">\</a>  CHtmlEditDoc::CHtmlEditDoc  
 Constructs a **CHtmlEditDoc** object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="chtmleditdoc__getview">\</a>  CHtmlEditDoc::GetView  
 Retrieves the [CHtmlEditView](../vs140/chtmleditview-class.md) object attached to this document.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the document's **CHtmlEditView** object.  
  
##  \<a name="chtmleditdoc__ismodified">\</a>  CHtmlEditDoc::IsModified  
 Returns whether the associated view's WebBrowser control contains a document that has been modified by the user.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="chtmleditdoc__openurl">\</a>  CHtmlEditDoc::OpenURL  
 Opens a URL.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The URL to open.  
  
### Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## See Also  
 [HTMLEdit Sample](../vs140/visual-c---samples.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)