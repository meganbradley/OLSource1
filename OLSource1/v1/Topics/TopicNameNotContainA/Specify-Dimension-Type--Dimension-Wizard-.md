---
title: Specify Dimension Type (Dimension Wizard)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - analysis-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3215282a-532d-4ff2-b721-286f088967fc
---
# Specify Dimension Type (Dimension Wizard)
  Use the **Specify Dimension Type** page to define the dimension type and add special attribute types associated with the selected dimension type to the dimension.  
  
> [!NOTE]  
>  This page is displayed only if you selected **Standard dimension** on the **Select the Dimension Type** page.  
  
## Options  
 **Dimension type**  
 Select the dimension type for the dimension. The following table lists the dimension types that are available.  
  
|Value|Description|  
|-----------|-----------------|  
|**Accounts**|Account dimensions contain data and metadata that represents a list of accounts.<br /><br /> For more information about account dimensions, see [Create a Finance Account of parent-child type Dimension](../../Topics\TopicNameContainA/Create-a-Finance-Account-of-parent-child-type-Dimension.md).|  
|**BillOfMaterials**|Bill\-of\-material \(or BOM\) dimensions are regular dimensions in which the data and metadata represent inventory or manufacturing information, such as part lists for products.<br /><br /> For more information about regular dimensions, see [Dimension Types](../Topic/Dimension%20Types.md).|  
|**Channel**|Channel dimensions are regular dimensions in which the data and metadata represent channel information.<br /><br /> For more information about regular dimensions, see [Dimension Types](../Topic/Dimension%20Types.md).|  
|**Currency**|Currency dimensions contain data and metadata that represent currency information.<br /><br /> For more information about currency dimensions, see [Create a Currency type Dimension](../../Topics\TopicNameContainA/Create-a-Currency-type-Dimension.md).|  
|**Customers**|Customer dimensions are regular dimensions in which the data and metadata represent customer or contact information.<br /><br /> For more information about regular dimensions, see [Dimension Types](../Topic/Dimension%20Types.md).|  
|**Geography**|Geography dimensions are regular dimensions in which the data and metadata represent geographic information, such as cities or postal codes.<br /><br /> For more information about regular dimensions, see [Dimension Types](../Topic/Dimension%20Types.md).|  
|**Organization**|Organization dimensions are regular dimensions in which the data and metadata represent organizational information, such as employees or subsidiaries.<br /><br /> For more information about regular dimensions, see [Dimension Types](../Topic/Dimension%20Types.md).|  
|**Products**|Product dimensions are regular dimensions in which the data and metadata represent product information.<br /><br /> For more information about regular dimensions, see [Dimension Types](../Topic/Dimension%20Types.md).|  
|**Promotion**|Promotion dimensions are regular dimensions in which the data and metadata represent marketing promotion information.<br /><br /> For more information about regular dimensions, see [Dimension Types](../Topic/Dimension%20Types.md).|  
|**Quantitative**|Quantitative dimensions are regular dimensions in which the data and metadata represent quantitative information.<br /><br /> For more information about regular dimensions, see [Dimension Types](../Topic/Dimension%20Types.md).|  
|**Rates**|Rate dimensions contain data and metadata that represent exchange rate and currency conversion information.|  
|**Regular**|Regular dimensions are the most common dimension type used in [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] [!INCLUDE[ssASnoversion](../../Token\Other/ssASnoversion_md.md)].<br /><br /> For more information about regular dimensions, see [Dimension Types](../Topic/Dimension%20Types.md).|  
|**Scenario**|Scenario dimensions are regular dimensions in which the data and metadata represent planning or strategic analysis information.<br /><br /> For more information about regular dimensions, see [Dimension Types](../Topic/Dimension%20Types.md).|  
|**Time**|Time dimensions contain time\-oriented data and metadata.<br /><br /> For more information about time dimensions, see [Create a Date type Dimension](../../Topics\TopicNameContainA/Create-a-Date-type-Dimension.md).|  
|**Utility**|Utility dimensions are regular dimensions in which the data and metadata represents information that does not readily match another dimension type.<br /><br /> For more information about regular dimensions, see [Dimension Types](../Topic/Dimension%20Types.md).|  
  
## Dimension attributes Options  
  
> [!NOTE]  
>  The options in this section become available only if the selected **Dimension type** has special attribute types associated with it. Not all dimension types have special attribute types associated with them.  
  
 **Include**  
 Select to include the attribute type in the dimension.  
  
 **Attribute Type**  
 Displays the attribute type associated with the dimension type selected in **Dimension type**. For more information about attribute types, see [Type Element &#40;DimensionAttribute&#41; &#40;ASSL&#41;](../Topic/Type%20Element%20\(DimensionAttribute\)%20\(ASSL\).md).  
  
 **Dimension Attribute**  
 Select the dimension attribute to which the Dimension Wizard will assign the special attribute type displayed in **Attribute Type**.  
  
## See Also  
 [Dimension Wizard F1 Help](../../Topics\TopicNameNotContainA/Dimension-Wizard-F1-Help.md)   
 [Dimensions &#40;Analysis Services - Multidimensional Data&#41;](../Topic/Dimensions%20\(Analysis%20Services%20-%20Multidimensional%20Data\).md)   
 [Dimensions in Multidimensional Models](../../Topics\TopicNameNotContainA/Dimensions-in-Multidimensional-Models.md)  
  
  