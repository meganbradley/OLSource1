---
title: "Dialog Data Exchange Functions for CRecordView and CDaoRecordView"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.mfc.macros.data"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_Field functions"
  - "ODBC [C++], dialog data exchange (DDX) support"
  - "DDX (dialog data exchange) [C++], database support"
  - "DDX (dialog data exchange) [C++], functions"
  - "databases [C++], dialog data exchange (DDX) support"
  - "DAO [C++], dialog data exchange (DDX) support"
ms.assetid: 0d8cde38-3a2c-4100-9589-ac80a7b1ce91
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dialog Data Exchange Functions for CRecordView and CDaoRecordView
This topic lists the DDX_Field functions used to exchange data between a [CRecordset](../VS_csharp/crecordset-class.md) and a [CRecordView](../VS_csharp/crecordview-class.md) form or a [CDaoRecordset](../VS_csharp/cdaorecordset-class.md) and a [CDaoRecordView](../VS_csharp/cdaorecordview-class.md) form.  
  
> [!NOTE]
>  DDX_Field functions are like DDX functions in that they exchange data with controls in a form. But unlike DDX, they exchange data with the fields of the view's associated recordset object rather than with fields of the record view itself. For more information, see classes `CRecordView` and `CDaoRecordView`.  
  
### DDX_Field Functions  
  
|||  
|-|-|  
|[DDX_FieldCBIndex](../VS_csharp/ddx_fieldcbindex.md)|Transfers integer data between a recordset field data member and the index of the current selection in a combo box in a [CRecordView](../VS_csharp/crecordview-class.md) or [CDaoRecordView](../VS_csharp/cdaorecordview-class.md).|  
|[DDX_FieldCBString](../VS_csharp/ddx_fieldcbstring.md)|Transfers `CString` data between a recordset field data member and the edit control of a combo box in a `CRecordView` or `CDaoRecordView`. When moving data from the recordset to the control, this function selects the item in the combo box that begins with the characters in the specified string.|  
|[DDX_FieldCBStringExact](../VS_csharp/ddx_fieldcbstringexact.md)|Transfers `CString` data between a recordset field data member and the edit control of a combo box in a `CRecordView` or `CDaoRecordView`. When moving data from the recordset to the control, this function selects the item in the combo box that exactly matches the specified string.|  
|[DDX_FieldCheck](../VS_csharp/ddx_fieldcheck.md)|Transfers Boolean data between a recordset field data member and a check box in a `CRecordView` or `CDaoRecordView`.|  
|[DDX_FieldLBIndex](../VS_csharp/ddx_fieldlbindex.md)|Transfers integer data between a recordset field data member and the index of the current selection in a list box in a `CRecordView` or `CDaoRecordView`.|  
|[DDX_FieldLBString](../VS_csharp/ddx_fieldlbstring.md)|Manages the transfer of [CString](../VS_csharp/cstringt-class.md) data between a list-box control and the field data members of a recordset. When moving data from the recordset to the control, this function selects the item in the list box that begins with the characters in the specified string.|  
|[DDX_FieldLBStringExact](../VS_csharp/ddx_fieldlbstringexact.md)|Manages the transfer of `CString` data between a list-box control and the field data members of a recordset. When moving data from the recordset to the control, this function selects the first item that exactly matches the specified string.|  
|[DDX_FieldRadio](../VS_csharp/ddx_fieldradio.md)|Transfers integer data between a recordset field data member and a group of radio buttons in a `CRecordView` or `CDaoRecordView`.|  
|[DDX_FieldScroll](../VS_csharp/ddx_fieldscroll.md)|Sets or gets the scroll position of a scroll bar control in a `CRecordView` or `CDaoRecordView`. Call from your [DoFieldExchange](../Topic/CDaoRecordset::DoFieldExchange.md) function.|  
|[DDX_FieldText](../VS_csharp/ddx_fieldtext.md)|Overloaded versions are available for transferring `int`, **UINT**, **long**, `DWORD`, [CString](../VS_csharp/cstringt-class.md), **float**, **double**, **short**, [COleDateTime](../VS_csharp/coledatetime-class.md), and [COleCurrency](../VS_csharp/colecurrency-class.md) data between a recordset field data member and an edit box in a `CRecordView` or `CDaoRecordView`.|  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)