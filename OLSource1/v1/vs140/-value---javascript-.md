---
title: "&lt;value&gt; (JavaScript)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "<value> JavaScript XML tag"
  - "value JavaScript XML tag"
ms.assetid: 983e31de-cb1d-411e-b60d-eea6698a26f6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;value&gt; (JavaScript)
Specifies documentation information for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions for ECMAScript 3 properties.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional. The data type of the property. The type can be one of the following:  
  
-   An ECMAScript language type that's in the ECMAScript 5 specification, such as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
-   A DOM object, such as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
-   A JavaScript constructor function.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, specifies whether the property is an integer. Set to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to indicate that the property is an integer; otherwise, set to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Optional. This attribute is deprecated; the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> attribute takes precedence over this attribute. This attribute specifies whether the documented property is a DOM element. Set to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to specify that the property is a DOM element; otherwise, set to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute is not set and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, IntelliSense treats the documented property as an <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> when performing statement completion.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Optional. Specifies whether the documented property can be set to null. Set to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to indicate that the property can be set to null; otherwise, set to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, this attribute specifies the type of the elements in the array.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, this attribute specifies whether the elements in the array are integers. Set to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to indicate that the elements in the array are integers; otherwise, set to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Optional. This attribute is deprecated; the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> attribute takes precedence over this attribute. If <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, this attribute specifies whether the elements in the array are DOM elements. Set to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to specify that the elements are DOM elements; otherwise, set to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> attribute is not set and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, IntelliSense treats each element in the array as an <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> when performing statement completion.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, specifies whether the elements in the array can be set to null. Set to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> to indicate that the elements in the array can be set to null; otherwise, set to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Optional. The identifier for localization information about the property. The identifier is either a member ID or it corresponds to the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../vs140/-loc---javascript-.md) element.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Optional. A description of the property.  
  
## Remarks  
 ECMAScript 5 properties use the [\<summary>](../vs140/-summary---javascript-.md) element.  
  
 Use the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> element immediately before the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> function.  
  
## Example  
 The following code example shows how to use the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> element on a <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation Comments](../vs140/xml-documentation-comments--javascript-.md)