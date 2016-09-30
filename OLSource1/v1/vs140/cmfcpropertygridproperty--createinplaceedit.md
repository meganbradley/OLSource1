---
title: "CMFCPropertyGridProperty::CreateInPlaceEdit"
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
  - "CMFCPropertyGridProperty::CreateInPlaceEdit"
  - "CMFCPropertyGridProperty.CreateInPlaceEdit"
  - "CreateInPlaceEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInPlaceEdit method"
ms.assetid: 29adb69d-c261-435a-a6fd-68aba4aaae6e
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty::CreateInPlaceEdit
Called by the framework to create an editable control for a property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The bounding rectangle of the editable control.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to use the default property format to set the text of the editable control; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 A pointer to the editable control if this method succeeds; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method uses the values of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameters that are specified in the [CMFCPropertyGridProperty](../vs140/cmfcpropertygridproperty-class.md) class constructor. By default, this method supports the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> variant types. This includes <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 This method creates a [CMFCMaskedEdit](../vs140/cmfcmaskededit-class.md) control if one or more of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameters are specified; otherwise, it creates a [CEdit](../vs140/cedit-class.md) control.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridProperty Class](../vs140/cmfcpropertygridproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit Class](../vs140/cedit-class.md)