---
title: Get-PowerPivotSystemServiceInstance cmdlet
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 56027a8e-1949-4349-b616-68c8b1d2963c
---
# Get-PowerPivotSystemServiceInstance cmdlet
  Returns one or more instances of [!INCLUDE[ssGemini](../../Token\Other/ssGemini_md.md)] System Service running on application servers in the farm.  
  
 **Applies To:** SharePoint 2010 and SharePoint 2013.  
  
## Syntax  
  
```  
Get-PowerPivotSystemServiceInstance [-Identity <PowerPivotMidTierServiceInstancePipeBind>] [<CommonParameters>]  
```  
  
## Description  
 The Get\-PowerPivotSystemServiceInstance cmdlet returns the properties of one or more [!INCLUDE[ssGemini](../../Token\Other/ssGemini_md.md)] System Service instances running in the farm. The cmdlet reports the application type, status \(online or offline\), and the identity. To view additional properties of a specific instance, add the Identity parameter and the format\-list option to the cmdlet.  
  
## Parameters  
  
### \-Identity \<PowerPivotMidTierServiceInstancePipeBind\>  
 Specifies the service instance to get. The value must be a valid GUID that uniquely identifies the object in the farm..  
  
|||  
|-|-|  
|Required?|false|  
|Position?|0|  
|Default value||  
|Accept pipeline input?|true|  
|Accept wildcard characters?|false|  
  
### \<CommonParameters\>  
 This cmdlet supports the common parameters: Verbose, Debug, ErrorAction, ErrorVariable, WarningAction, WarningVariable,OutBuffer and OutVariable. For more information, see [About\_CommonParameters](http://go.microsoft.com/fwlink/?linkID=227825)  
  
## Inputs and Outputs  
 The input type is the type of the objects that you can pipe to the cmdlet. The return type is the type of the objects that the cmdlet returns.  
  
|||  
|-|-|  
|Inputs|None.|  
|Outputs|None.|  
  
## Example 1  
  
```  
C:\PS>Get-PowerPivotSystemServiceInstance -Identity 1234567-890a-bcde-fghijklm | format-list| format-list  
```  
  
 This example returns additional properties of the specified instance, including the server name, version, and upgrade status.  
  
  