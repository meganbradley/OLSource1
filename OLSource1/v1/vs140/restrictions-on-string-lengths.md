---
title: "Restrictions on String Lengths"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - source control plug-ins, restrictions on string lengths
ms.assetid: 877173d2-ca27-43b3-b1f4-8379f7c5e268
caps.latest.revision: 18
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Restrictions on String Lengths
The Source Control Plug-in API limits the lengths of strings used in various functions.  
  
## String Length Values  
  
|Constant|Value|  
|--------------|-----------|  
|`SCC_NAME_LEN`|31|  
|`SCC_AUXLABEL_LEN`|31|  
|`SCC_USER_LEN`|31|  
|`SCC_PRJPATH_LEN`|300|  
  
> [!NOTE]
>  Length does not include the terminating `null`. Other constants with a "_SIZE" suffix instead of "_LEN" do include space for the terminating `null`.  
  
|Constant|Value|  
|--------------|-----------|  
|SCC_NAME_SIZE|32|  
|SCC_AUXLABEL_SIZE|32|  
|SCC_USER_SIZE|32|  
|SCC_PRJPATH_SIZE|301|  
  
## See Also  
 [Source Control Plug-ins](../vs140/source-control-plug-ins.md)