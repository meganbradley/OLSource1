---
title: "Dialog Data Validation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "validating data [C++], message boxes"
  - "data validation [C++], dialog boxes"
  - "dialog boxes [C++], validating data"
  - "validating data [C++], dialog box data entry"
  - "DDV (dialog data validation) [C++]"
  - "data validation [C++], message boxes"
ms.assetid: f070c309-2044-4ff2-8c92-1ec1ea84af58
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dialog Data Validation
You can specify validation in addition to data exchange by calling DDV functions, as shown in the example in [Dialog Data Exchange](../vs140/dialog-data-exchange.md). The `DDV_MaxChars` call in the example validates that the string entered in the text-box control is not longer than 20 characters. The DDV function typically alerts the user with a message box if the validation fails and puts the focus on the offending control so the user can reenter the data. A DDV function for a given control must be called immediately after the DDX function for the same control.  
  
 You can also define your own custom DDX and DDV routines. For details on this and other aspects of DDX and DDV, see [MFC Technical Note 26](../vs140/tn026--ddx-and-ddv-routines.md).  
  
 The [Add Member Variable Wizard](../vs140/add-member-variable-wizard.md) will write all of the DDX and DDV calls in the data map for you.  
  
## See Also  
 [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md)   
 [Life Cycle of a Dialog Box](../vs140/life-cycle-of-a-dialog-box.md)   
 [Dialog Data Exchange](../vs140/dialog-data-exchange.md)