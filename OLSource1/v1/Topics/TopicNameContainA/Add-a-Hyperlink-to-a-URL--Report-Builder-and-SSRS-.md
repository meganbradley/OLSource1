---
title: Add a Hyperlink to a URL (Report Builder and SSRS)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d3392c0b-7b62-4d27-bc04-2bd0c5487d08
---
# Add a Hyperlink to a URL (Report Builder and SSRS)
  You can add a hyperlink to a report item when you want your users to be able to click a link in a report and open a browser to the URL that you specify. A hyperlink can be a static URL or an expression that evaluates to a URL. If you have a field in a database that contains URLs, the expression can contain that field, resulting in a dynamic list of hyperlinks in the report. You can add hyperlinks to text boxes, images, charts, and gauges. You must ensure that the user has access to the URL that you provide.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Token\Other/ssRBRDDup_md.md)]  
  
 You can also specify URLs to reports on any report server that you and your users have permission to view using URL requests to the report server. For example, you can specify a report and hide the document map for the user when they first view the report. For more information, see [URL Access &#40;SSRS&#41;](../Topic/URL%20Access%20\(SSRS\).md) in the [Reporting Services documentation](http://go.microsoft.com/fwlink/?linkid=121312) in [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)] Books Online.  
  
 You can add a hyperlink to a URL to any item that has an **Action** property, for example, a text box, an image, or a calculated series in a chart. When the user clicks that report item, the action that you define takes place. For more information, see the [Action Properties Dialog Box &#40;Report Builder and SSRS&#41;](../Topic/Action%20Properties%20Dialog%20Box%20\(Report%20Builder%20and%20SSRS\).md) and [Specifying Paths to External Items &#40;Report Builder and SSRS&#41;](../Topic/Specifying%20Paths%20to%20External%20Items%20\(Report%20Builder%20and%20SSRS\).md).  
  
 To quickly get started, see [Tutorial: Format Text &#40;Report Builder&#41;](../Topic/Tutorial:%20Format%20Text%20\(Report%20Builder\).md).  
  
> [!NOTE]  
>  Links that are bound to dataset fields can be vulnerable to tampering for malicious purposes. For more information, see [Secure Reports and Resources](../../Topics\TopicNameNotContainA/Secure-Reports-and-Resources.md) in [!INCLUDE[ssNoVersion](../../Token\Other/ssNoVersion_md.md)][Books Online](http://go.microsoft.com/fwlink/?LinkId=154888) on msdn.microsoft.com.  
  
### To add a hyperlink  
  
1.  In report design view, right\-click the text box, image, or chart to which you want to add a link and then click **Properties**.  
  
2.  In the Properties dialog box, click **Action**.  
  
3.  Select **Go to URL**. An additional section appears in the dialog box for this option.  
  
4.  In **Select URL**, type or select a URL or an expression that evaluates to a URL, or click the drop\-down arrow and click the name of a field that contains a URL.  
  
5.  [!INCLUDE[clickOK](../../Token\Other/clickOK_md.md)]  
  
6.  \(Optional\) The text is not automatically formatted as a link. For text, it is helpful to change the color and effect of the text to indicate that the text is a link. For example, change the color to blue and the effect to underline in the **Font** section in the Home tab of the Ribbon.  
  
7.  To test the link, click **Run** to preview the report, and then click the report item that you set this link on.  
  
## See Also  
 [Interactive Sort, Document Maps, and Links &#40;Report Builder and SSRS&#41;](../Topic/Interactive%20Sort,%20Document%20Maps,%20and%20Links%20\(Report%20Builder%20and%20SSRS\).md)   
 [Create a Document Map &#40;Report Builder and SSRS&#41;](../Topic/Create%20a%20Document%20Map%20\(Report%20Builder%20and%20SSRS\).md)  
  
  