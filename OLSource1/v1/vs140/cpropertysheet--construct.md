---
title: "CPropertySheet::Construct"
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
  - "CPropertySheet.Construct"
  - "CPropertySheet::Construct"
  - "Construct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropertySheet class, construction"
  - "Construct method"
ms.assetid: cda4f3af-d6c1-4863-9be3-1dd2d5416cc7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::Construct
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 ID of the caption to be used for the property sheet.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the parent window of the property sheet. If **NULL**, the parent window will be the main window of the application.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The index of the page that will initially be on top. Default is the first page added to the sheet.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a string containing the caption to be used for the property sheet. Cannot be **NULL**.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Handle to the watermark bitmap of the property page.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Handle to the palette of the watermark bitmap and/or header bitmap.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Handle to the header bitmap of the property page.  
  
## Remarks  
 Call this member function if one of the class constructors has not already been called. For example, call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> when you declare or allocate arrays of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects. In the case of arrays, you must call <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for each member in the array.  
  
 To display the property sheet, call [DoModal](../vs140/cpropertysheet--domodal.md) or [Create](../vs140/cpropertysheet--create.md). The string contained in the first parameter will be placed in the caption bar for the property sheet.  
  
 You can display watermark and/or header images automatically if you use the third or fourth prototypes of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, listed above, and you pass valid values for the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and/or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameters.  
  
## Example  
 The following example demonstrates under what circumstances you would call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 [!code[NVC_MFCDocView#130](../vs140/codesnippet/CPP/cpropertysheet--construct_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::CPropertySheet](../vs140/cpropertysheet--cpropertysheet.md)   
 [CPropertySheet::DoModal](../vs140/cpropertysheet--domodal.md)   
 [CPropertySheet::Create](../vs140/cpropertysheet--create.md)