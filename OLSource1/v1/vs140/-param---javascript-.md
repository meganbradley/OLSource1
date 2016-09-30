---
title: "&lt;param&gt; (JavaScript)"
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
  - "<param> JavaScript XML tag"
  - "param JavaScript XML tag"
ms.assetid: 2c4e0167-c1dd-4e54-83f1-c437856bddc1
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;param&gt; (JavaScript)
Specifies documentation information for a parameter in a function or method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. The name of the parameter.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional. The data type of the parameter. The type can be one of the following:  
  
-   An ECMAScript language type in the ECMAScript 5 specification, such as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
-   A DOM object, such as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
-   A JavaScript constructor function.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, specifies whether the parameter is an integer. Set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to indicate that the parameter is an integer; otherwise, set to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Optional. This attribute is deprecated; the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> attribute takes precedence over this attribute. This attribute specifies whether the documented parameter is a DOM element. Set to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to specify that the parameter is a DOM element; otherwise, set to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> attribute is not set and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, IntelliSense treats the documented parameter as an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> when performing statement completion.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Optional. Specifies whether the documented parameter can be set to null. Set to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to indicate that the parameter can be set to null; otherwise, set to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, this attribute specifies the type of the elements in the array.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, this attribute specifies whether the elements in the array are integers. Set to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to indicate that the elements in the array are integers; otherwise, set to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Optional. This attribute is deprecated; the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> attribute takes precedence over this attribute. If <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, this attribute specifies whether the elements in the array are DOM elements. Set to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to specify that the elements are DOM elements; otherwise, set to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> attribute is not set and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, IntelliSense treats each element in the array as an <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> when performing statement completion.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, specifies whether the elements in the array can be set to null. Set to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to indicate that the elements in the array can be set to null; otherwise, set to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Optional. The identifier for localization information about the parameter. The identifier is either a member ID or it corresponds to the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../vs140/-loc---javascript-.md) element.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Optional. Specifies whether the documented parameter can be repeated in the function call, similar to repeating parameters supported in the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> function. Set to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> to indicate that the parameter can be repeated; otherwise, set to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Optional. Specifies whether the documented parameter is optional in the calling function. Set to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to indicate that the parameter is optional; otherwise, set to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Optional. Specifies code that should be evaluated for use by IntelliSense instead of the function code itself. You can use this attribute is to provide type information when the parameter type is undefined. For example, you can use <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to treat the parameter type as a number.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Optional. A description of the parameter.  
  
## Remarks  
 The only required attribute is <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>. All other attributes are optional.  
  
 Elements used to annotate functions, such as [\<summary>](../vs140/-summary---javascript-.md), [\<param>](../vs140/-param---javascript-.md), and [\<returns>](../vs140/-returns---javascript-.md), must be placed in the function body before any statements.  
  
 If there are multiple <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> elements that have the same name, one of the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> elements is used and the redundant elements are ignored. The behavior that determines which element is used is not defined. If <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> refers to a nonexistent parameter, the element is ignored.  
  
## Example  
 The following code example shows how to use the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation Comments](../vs140/xml-documentation-comments--javascript-.md)