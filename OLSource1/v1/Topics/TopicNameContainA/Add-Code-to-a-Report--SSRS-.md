---
title: Add Code to a Report (SSRS)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 00ef8fc6-99fe-49b2-8a22-7eb475881dc4
---
# Add Code to a Report (SSRS)
  In any expression, you can call your own custom code. You can provide code in the following two ways:  
  
-   Embed code written in [!INCLUDE[vbprvb](../../Token\Other/vbprvb_md.md)] directly in your report. If your code refers to a [!INCLUDE[msCoName](../../Token\Other/msCoName_md.md)] [!INCLUDE[dnprdnshort](../../Token\Other/dnprdnshort_md.md)] that is not [System.Math](assetId:///T:System.Math) or [System.Convert](assetId:///T:System.Convert), you must add the reference to the report. For more information, see [Add an Assembly Reference to a Report &#40;SSRS&#41;](../Topic/Add%20an%20Assembly%20Reference%20to%20a%20Report%20\(SSRS\).md). For more information about other references you can make from your code, see [Custom Code and Assembly References in Expressions in Report Designer &#40;SSRS&#41;](../Topic/Custom%20Code%20and%20Assembly%20References%20in%20Expressions%20in%20Report%20Designer%20\(SSRS\).md).  
  
-   Provide a custom code assembly by using the [!INCLUDE[dnprdnshort](../../Token\Other/dnprdnshort_md.md)]. If you provide a custom assembly, you must install it on both the computer where you author the report and the report server where you view the report. For more information, see [Using Custom Assemblies with Reports](../Topic/Using%20Custom%20Assemblies%20with%20Reports.md).  
  
### To add embedded code to a report  
  
1.  In **Design** view, right\-click the design surface outside the border of the report and click **Report Properties**.  
  
2.  Click **Code**.  
  
3.  In **Custom code**, type the code. Errors in the code produce warnings when the report runs. The following example creates a custom function named `ChangeWord` that replaces the word "`Bike`" with "`Bicycle`".  
  
    ```  
    Public Function ChangeWord(ByVal s As String) As String  
       Dim strBuilder As New System.Text.StringBuilder(s)  
       If s.Contains("Bike") Then  
          strBuilder.Replace("Bike", "Bicycle")  
          Return strBuilder.ToString()  
          Else : Return s  
       End If  
    End Function  
    ```  
  
4.  The following example shows how to pass a dataset field named Category to this function in an expression:  
  
    ```  
    =Code.ChangeWord(Fields!Category.Value)  
    ```  
  
     If you add this expression to a table cell that displays category values, whenever the word "Bike" is in the dataset field for that row, the table cell value displays the word "Bicycle" instead.  
  
## See Also  
 [Report Properties Dialog Box, Code](../../Topics\TopicNameNotContainA/Report-Properties-Dialog-Box,-Code.md)   
 [Expression Examples &#40;Report Builder and SSRS&#41;](../Topic/Expression%20Examples%20\(Report%20Builder%20and%20SSRS\).md)   
 [Parameters Collection References &#40;Report Builder and SSRS&#41;](../Topic/Parameters%20Collection%20References%20\(Report%20Builder%20and%20SSRS\).md)  
  
  