---
title: "COlePropertiesDialog::OnApplyScale"
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
  - "COlePropertiesDialog::OnApplyScale"
  - "OnApplyScale"
  - "COlePropertiesDialog.OnApplyScale"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnApplyScale method"
  - "COlePropertiesDialog class, overridables"
ms.assetid: a77791f0-78d3-4ab3-9fa4-26895adb54ed
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePropertiesDialog::OnApplyScale
Called by the framework when the scaling value has changed and either OK or Apply was selected.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the document item whose properties are being accessed.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Numerical value of the dialog scale.  
  
 *bRelativeToOrig*  
 Indicates whether scaling applies to the original size of the document item.  
  
## Return Value  
 Nonzero if handled; otherwise 0.  
  
## Remarks  
 The default implementation does nothing. You must override this function to enable the scaling controls.  
  
> [!NOTE]
>  Before the common OLE Object Properties dialog box is displayed, the framework calls this function with a **NULL** for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and a – 1 for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This is done to determine if the scaling controls should be enabled.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COlePropertiesDialog Class](../vs140/colepropertiesdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COlePropertiesDialog::DoModal](../vs140/colepropertiesdialog--domodal.md)