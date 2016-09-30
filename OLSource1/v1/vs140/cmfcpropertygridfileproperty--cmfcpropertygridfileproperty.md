---
title: "CMFCPropertyGridFileProperty::CMFCPropertyGridFileProperty"
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
  - "CMFCPropertyGridFileProperty.CMFCPropertyGridFileProperty"
  - "CMFCPropertyGridFileProperty"
  - "CMFCPropertyGridFileProperty::CMFCPropertyGridFileProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPropertyGridFileProperty class, constructor"
ms.assetid: 634445d5-97c5-485d-acef-9bcce8b628cd
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridFileProperty::CMFCPropertyGridFileProperty
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The property name.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to open an **Open File**dialog box; <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to open a **Save File** dialog box.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The initial file name.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A string of one or more file name extensions. The default value is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Dialog box flags. The default value is a bitwise combination (OR) of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A string of one or more file filters. The default value is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The property item description. The default value is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Application-specific data that is associated with the property item. For example, a 32-bit integer or a pointer to other data. The default value is 0.  
  
## Return Value  
  
## Remarks  
 For a full list of available flags, see [OPENFILENAME structure](https://msdn.microsoft.com/library/ms646839.aspx).  
  
## Example  
 The following example demonstrates how to create an object using the constructor of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class. This example is part of the [Visual Studio Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#22](../vs140/codesnippet/CPP/cmfcpropertygridfileproperty--cmfcpropertygridfileproperty_1.cpp)]  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridFileProperty Class](../vs140/cmfcpropertygridfileproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)