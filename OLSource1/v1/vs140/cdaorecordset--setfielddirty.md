---
title: "CDaoRecordset::SetFieldDirty"
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
  - "SetFieldDirty"
  - "CDaoRecordset.SetFieldDirty"
  - "CDaoRecordset::SetFieldDirty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, setting field flags and values"
  - "CDaoRecordset class, setting field dirty"
  - "SetFieldDirty method"
ms.assetid: f37ab4d9-6501-450b-8c74-b9cc7bf47569
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::SetFieldDirty
Call this member function to flag a field data member of the recordset as changed or as unchanged.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contains the address of a field data member in the recordset or **NULL**. If **NULL**, all field data members in the recordset are flagged. (C++ **NULL** is not the same as Null in database terminology, which means "having no value.")  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **TRUE** if the field data member is to be flagged as "dirty" (changed). Otherwise **FALSE** if the field data member is to be flagged as "clean" (unchanged).  
  
## Remarks  
 Marking fields as unchanged ensures the field is not updated.  
  
 The framework marks changed field data members to ensure they will be written to the record on the data source by the DAO record field exchange (DFX) mechanism. Changing the value of a field generally sets the field dirty automatically, so you will seldom need to call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> yourself, but you might sometimes want to ensure that columns will be explicitly updated or inserted regardless of what value is in the field data member. The DFX mechanism also employs the use of **PSEUDO NULL**. For more information, see [CDaoFieldExchange::m_nOperation](../vs140/cdaofieldexchange--m_noperation.md).  
  
 If the double-buffering mechanism is not being used, then changing the value of the field does not automatically set the field as dirty. In this case, it will be necessary to explicitly set the field as dirty. The flag contained in [m_bCheckCacheForDirtyFields](../vs140/cdaorecordset--m_bcheckcachefordirtyfields.md) controls this automatic field checking.  
  
> [!NOTE]
>  Call this member function only after you have called [Edit](../vs140/cdaorecordset--edit.md) or [AddNew](../vs140/cdaorecordset--addnew.md).  
  
 Using **NULL** for the first argument of the function will apply the function to all **outputColumn** fields, not **param** fields in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For instance, the call  
  
 [!code[NVC_MFCDatabase#6](../vs140/codesnippet/CPP/cdaorecordset--setfielddirty_1.cpp)]  
  
 will set only **outputColumn** fields to **NULL**; **param** fields will be unaffected.  
  
 To work on a **param**, you must supply the actual address of the individual **param** you want to work on, such as:  
  
 [!code[NVC_MFCDatabase#7](../vs140/codesnippet/CPP/cdaorecordset--setfielddirty_2.cpp)]  
  
 This means you cannot set all **param** fields to **NULL**, as you can with **outputColumn** fields.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is implemented through <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::SetFieldNull](../vs140/cdaorecordset--setfieldnull.md)   
 [CDaoRecordset::SetFieldValue](../vs140/cdaorecordset--setfieldvalue.md)