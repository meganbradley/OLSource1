---
title: "One or more properties in the .ofs file are not valid for the message class selected"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VSTO.NewFormRegionWizard.OFSPropertyError"
dev_langs: 
  - "VB"
  - "CSharp"
ms.assetid: ca9e2ec1-df96-45ca-9611-cec47edfe1e4
caps.latest.revision: 8
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# One or more properties in the .ofs file are not valid for the message class selected
  This error appears when you import a form region that is designed in Outlook, but one or more fields on the form region are not compatible with the message classes that you select on the final page of the **New Form Region** wizard.  
  
 For example, you might select **Task (IPM.Task)** on the final page of the **New Form Region** wizard. If the form region contains a **Business Address** field, you will receive this error because a task does not have a business address. Therefore, the **Business Address** field is not compatible with the IPM.Task message class.  
  
### To correct this error  
  
-   On the final page of the **New Form Region** wizard, select a message class that is compatible with the fields on the form region.  
  
-   In the Forms Designer in Outlook, remove fields that are not compatible with the message classes that you plan to select on the final page of the **New Form Region** wizard.  
  
## See Also  
 [Walkthrough: Importing a Form Region That Is Designed in Outlook](../VS_officedev/walkthrough--importing-a-form-region-that-is-designed-in-outlook.md)  
  
  