---
title: "CPropertySheet::CPropertySheet"
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
  - "CPropertySheet.CPropertySheet"
  - "CPropertySheet::CPropertySheet"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropertySheet class, constructor"
ms.assetid: 25c29c0e-ef35-4877-aaa5-e47cc68dbe6b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::CPropertySheet
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 ID of the caption to be used for the property sheet.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the parent window of the property sheet. If **NULL**, the parent window will be the main window of the application.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The index of the page that will initially be on top. Default is the first page added to the sheet.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Points to a string containing the caption to be used for the property sheet. Cannot be **NULL**.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A handle to the background bitmap of the property sheet.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A handle to the palette of the watermark bitmap and/or header bitmap.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A handle to the header bitmap of the property page.  
  
## Remarks  
 To display the property sheet, call [DoModal](../vs140/cpropertysheet--domodal.md) or [Create](../vs140/cpropertysheet--create.md). The string contained in the first parameter will be placed in the caption bar for the property sheet.  
  
 If you have multiple parameters (for example, if you are using an array), use [Construct](../vs140/cpropertysheet--construct.md) instead of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 You can display watermark and/or header images automatically if you use the third or fourth prototypes of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, above, and you pass valid values for the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and/or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameters.  
  
## Example  
 [!code[NVC_MFCDocView#131](../vs140/codesnippet/CPP/cpropertysheet--cpropertysheet_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::Construct](../vs140/cpropertysheet--construct.md)   
 [CPropertySheet::DoModal](../vs140/cpropertysheet--domodal.md)   
 [CPropertySheet::Create](../vs140/cpropertysheet--create.md)   
 [CPropertyPage::CPropertyPage](../vs140/cpropertypage--cpropertypage.md)