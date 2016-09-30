---
title: "CRecordView::CRecordView"
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
  - "CRecordView.CRecordView"
  - "CRecordView::CRecordView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRecordView class, constructor"
ms.assetid: 405e9858-98e7-4bb8-a261-04085c20d442
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordView::CRecordView
When you create an object of a type derived from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, call either form of the constructor to initialize the view object and identify the dialog resource on which the view is based.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains a null-terminated string that is the name of a dialog template resource.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Contains the ID number of a dialog template resource.  
  
## Remarks  
 You can either identify the resource by name (pass a string as the argument to the constructor) or by its ID (pass an unsigned integer as the argument). Using a resource ID is recommended.  
  
> [!NOTE]
>  Your derived class *must* supply its own constructor. In the constructor of your derived class, call the constructor <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with the resource name or ID as an argument, as shown in the example below.  
  
 **CRecordView::OnInitialUpdate** calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. This initial call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> connects <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> controls (indirectly) to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> field data members created by ClassWizard. These data members cannot be used until after you call the base class **CFormView::OnInitialUpdate** member function.  
  
> [!NOTE]
>  If you use ClassWizard, the wizard defines an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, specifies it in the class declaration, and uses it in the member initialization list for the constructor.  
  
## Example  
 [!code[NVC_MFCDatabase#32](../vs140/codesnippet/CPP/crecordview--crecordview_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordView Class](../vs140/crecordview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::DoFieldExchange](../vs140/crecordset--dofieldexchange.md)   
 [CView::OnInitialUpdate](../vs140/cview--oninitialupdate.md)   
 [CWnd::UpdateData](../vs140/cwnd--updatedata.md)