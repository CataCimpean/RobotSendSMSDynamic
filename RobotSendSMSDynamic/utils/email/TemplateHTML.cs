using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic.utils.email
{
    class TemplateHTML
    {

         public static string BuildHTMLTemplate(String numePagina,String numeRaport) {
            
            string htmlBody =
                "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\n" +
                "<html xmlns=\"http://www.w3.org/1999/xhtml\">\n" +
                "<head>\n" +
                "<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\" />\n" +
                "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\" />\n" +
                "<title></title>\n" +
                "\n" +
                "<style type=\"text/css\">@media only screen and (max-width:480px){body,table,td,p,a,li,blockquote{-webkit-text-size-adjust:none !important}body{width:100% !important;min-width:100% !important}td[id=bodyCell]{padding:10px !important}table.kmMobileHide{display:none !important}table[class=kmTextContentContainer]{width:100% !important}table[class=kmBoxedTextContentContainer]{width:100% !important}td[class=kmImageContent]{padding-left:0 !important;padding-right:0 !important}img[class=kmImage]{width:100% !important}td.kmMobileStretch{padding-left:0 !important;padding-right:0 !important}table[class=kmSplitContentLeftContentContainer],table[class=kmSplitContentRightContentContainer],table[class=kmColumnContainer],td[class=kmVerticalButtonBarContentOuter] table[class=kmButtonBarContent],td[class=kmVerticalButtonCollectionContentOuter] table[class=kmButtonCollectionContent],table[class=kmVerticalButton],table[class=kmVerticalButtonContent]{width:100% !important}td[class=kmButtonCollectionInner]{padding-left:9px !important;padding-right:9px !important;padding-top:9px !important;padding-bottom:0 !important;background-color:transparent !important}td[class=kmVerticalButtonIconContent],td[class=kmVerticalButtonTextContent],td[class=kmVerticalButtonContentOuter]{padding-left:0 !important;padding-right:0 !important;padding-bottom:9px !important}table[class=kmSplitContentLeftContentContainer] td[class=kmTextContent],table[class=kmSplitContentRightContentContainer] td[class=kmTextContent],table[class=kmColumnContainer] td[class=kmTextContent],table[class=kmSplitContentLeftContentContainer] td[class=kmImageContent],table[class=kmSplitContentRightContentContainer] td[class=kmImageContent]{padding-top:9px !important}td[class=\"rowContainer kmFloatLeft\"],td[class=\"rowContainer kmFloatLeft firstColumn\"],td[class=\"rowContainer kmFloatLeft lastColumn\"]{float:left;clear:both;width:100% !important}table[id=templateContainer],table[class=templateRow]{max-width:600px !important;width:100% !important}h1{font-size:24px !important;line-height:130% !important}h2{font-size:20px !important;line-height:130% !important}h3{font-size:18px !important;line-height:130% !important}h4{font-size:16px !important;line-height:130% !important}td[class=kmTextContent]{font-size:14px !important;line-height:130% !important}td[class=kmTextBlockInner] td[class=kmTextContent]{padding-right:18px !important;padding-left:18px !important}table[class=\"kmTableBlock kmTableMobile\"] td[class=kmTableBlockInner]{padding-left:9px !important;padding-right:9px !important}table[class=\"kmTableBlock kmTableMobile\"] td[class=kmTableBlockInner] [class=kmTextContent]{font-size:14px !important;line-height:130% !important;padding-left:4px !important;padding-right:4px !important}}</style>\n" +
                "</head>\n" +
                "<body style=\"margin:0;padding:0;background-color:#c7c7c7\">\n" +
                "<center>\n" +
                "<table align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" id=\"bodyTable\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;padding:0;background-color:#c7c7c7;height:100%;margin:0;width:100%\">\n" +
                "<tbody>\n" +
                "<tr>\n" +
                "<td align=\"center\" id=\"bodyCell\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;padding-top:50px;padding-left:20px;padding-bottom:20px;padding-right:20px;border-top:0;height:100%;margin:0;width:100%\">\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" id=\"templateContainer\" width=\"600\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;border:1px solid #aaa;background-color:#f4f4f4;border-radius:0\">\n" +
                "<tbody>\n" +
                "<tr>\n" +
                "<td id=\"templateContainerInner\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;padding:0\">\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tr>\n" +
                "<td align=\"center\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"templateRow\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody>\n" +
                "<tr>\n" +
                "<td class=\"rowContainer kmFloatLeft\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"kmImageBlock\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody class=\"kmImageBlockOuter\">\n" +
                "<tr>\n" +
                "<td class=\"kmImageBlockInner\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;padding:9px;\" valign=\"top\">\n" +
                "<table align=\"left\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"kmImageContentContainer\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody>\n" +
                 "<tr>\n" +
                "<td class=\"kmImageContent\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;padding:0;padding-top:0px;padding-bottom:0;padding-left:9px;padding-right:9px;text-align: center;\">\n" +
                "<img align=\"center\" alt=\"\" class=\"kmImage\" src=\"C:\\Users\\Cimpean\\Documents\\Visual Studio 2013\\Projects\\RobotSendSMSDynamic\\RobotSendSMSDynamic\\utils\\image\\BSCJTemplate.png\"  width=\"200\" style=\"border:0;height:auto;line-height:50%;outline:none;text-decoration:none;padding-bottom:0;display:inline;vertical-align:bottom;max-width:200px;\" />\n" +
                "<center><img align=\"center\" src=\"http://bscj.ro/media/1005/sala_noua.jpg\" width=\"300\" /></center>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "<tr>\n" +
                "<td align=\"center\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"templateRow\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody>\n" +
                "<tr>\n" +
                "<td class=\"rowContainer kmFloatLeft\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"kmTableBlock kmTableMobile\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody class=\"kmTableBlockOuter\">\n" +
                "<tr>\n" +
                "<td class=\"kmTableBlockInner\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;padding-top:9px;padding-bottom:9px;padding-left:18px;padding-right:18px;\">\n" +
                "<table align=\"left\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"kmTable\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;\">\n" +
                "<thead>\n" +
                "<tr>\n" +
                "<th valign=\"top\" class=\"kmTextContent\" style=\"color:#505050;font-family:Helvetica, Arial;font-size:14px;line-height:150%;text-align:left;text-align:left;padding-top:4px;font-weight:bold;padding-right:0px;padding-left:0px;padding-bottom:4px;\">\n" +
                "     " + numePagina + "\n" +
                "    </th>\n" +
                "</tr>\n" +
                "</thead>\n" +
                "<tbody>\n" +
                "<tr class=\"kmTableRow\">\n" +
                "<td valign=\"top\" class=\"kmTextContent\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;color:#505050;font-family:Helvetica, Arial;font-size:14px;line-height:150%;text-align:left;border-right:none;border-bottom:none;text-align:left;;border-top-style:solid;padding-bottom:4px;padding-right:0px;padding-left:0px;padding-top:4px;border-top-color:#d9d9d9;border-top-width:1px;\">\n" +
                "<p style=\"margin:0;padding-bottom:1em\">Buna ziua, <br></p>\n" +
                "<p style=\"margin:0;padding-bottom:1em\"> " + "<b>Mesaj:</b>" + numeRaport + " <br> </p>\n" +
                "<p style=\"margin:0;padding-bottom:1em\"> " + "Va multumim ! " + "</p>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" class=\"kmDividerBlock\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody class=\"kmDividerBlockOuter\">\n" +
                "<tr>\n" +
                "<td class=\"kmDividerBlockInner\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;padding-top:18px;padding-bottom:18px;padding-left:18px;padding-right:18px;\">\n" +
                "<table class=\"kmDividerContent\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;border-top-width:1px;border-top-style:solid;border-top-color:#ccc;\">\n" +
                "<tbody>\n" +
                "<tr><td style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\"><span></span></td></tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"kmTextBlock\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody class=\"kmTextBlockOuter\">\n" +
                "<tr>\n" +
                "<td class=\"kmTextBlockInner\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;\">\n" +
                "<table align=\"left\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"kmTextContentContainer\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody>\n" +
                "<tr>\n" +
                "<td class=\"kmTextContent\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;color:#505050;font-family:Helvetica, Arial;font-size:14px;line-height:150%;text-align:left;padding-top:9px;padding-bottom:9px;padding-left:18px;padding-right:18px;\">\n" +
                "<p style=\"margin:0;padding-bottom:1em;line-height: 20.8px;\"><strong></strong></p>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"kmButtonCollectionBlock\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody class=\"kmButtonCollectionOuter\">\n" +
                "<tr>\n" +
                "<td class=\"kmButtonCollectionInner\" align=\"center\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;padding:9px 18px;\">\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"kmButtonCollectionContentContainer\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody>\n" +
                "<tr>\n" +
                "<td align=\"left\" class=\"kmVerticalButtonCollectionContentOuter\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"kmButtonCollectionContent\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;font-family:Helvetica, Arial\">\n" +
                "<tbody>\n" +
                "<tr>\n" +
                "<td align=\"left\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"kmVerticalButton\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody>\n" +
                "<tr>\n" +
                "<td valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"kmTextBlock\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody class=\"kmTextBlockOuter\">\n" +
                "<tr>\n" +
                "<td class=\"kmTextBlockInner\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;\">\n" +
                "<table align=\"left\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"kmTextContentContainer\" width=\"100%\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0\">\n" +
                "<tbody>\n" +
                "<tr>\n" +
                "<td class=\"kmTextContent\" valign=\"top\" style=\"border-collapse:collapse;mso-table-lspace:0;mso-table-rspace:0;color:#505050;font-family:Helvetica, Arial;font-size:14px;line-height:150%;text-align:left;font-size:11px;color:#a9a9a9;padding-bottom:9px;text-align:center;padding-right:18px;padding-left:18px;padding-top:9px;\">\n" +
                "<span style=\"background-color:#FF0000;\"></span>\n" +
                "<p style=\"margin:0;padding-bottom:1em\"><span style=\"color:#FF0000;\">Acesta este un e-mail generat automat. Va rugam sa nu dati reply.</span></p>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</td>\n" +
                "</tr>\n" +
                "</tbody>\n" +
                "</table>\n" +
                "</center>\n" +
                "</body>\n" +
                "</html>\n";

            return htmlBody;
        }

    }
}
