using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class DeliveryXmlFill
    {
        internal static XElement FillDelivery(Delivery delivery)
        {
            if (delivery != null)
            {
                XElement NodoDelivery = new XElement(NamespaceProvider.Cac + "Delivery");

                if (delivery.ActualDeliveryDate.HasValue)
                    NodoDelivery.Add(new XElement(NamespaceProvider.Cbc  + "ActualDeliveryDate", delivery.ActualDeliveryDate.Value.ToString("yyyy-MM-dd")));
                if (delivery.ActualDeliveryTime.HasValue)
                    NodoDelivery.Add(new XElement(NamespaceProvider.Cbc + "ActualDeliveryTime", delivery.ActualDeliveryTime.Value.ToString("HH:mm:ss-05:00")));

                if (delivery.DeliveryAddress != null)
                {
                    XElement address = AddressXmlFill.FillAddress(delivery.DeliveryAddress, "DeliveryAddress");
                    if (address.HasElements)
                        NodoDelivery.Add(address);
                }

                XElement DeliveryParty = new XElement(NamespaceProvider.Cac + "DeliveryParty");

                if (delivery.DeliveryParty != null)
                {
                    DeliveryParty.Add(new XElement(NamespaceProvider.Cbc + "MarkCareIndicator", delivery.DeliveryParty.MarkCareIndicator));
                    DeliveryParty.Add(new XElement(NamespaceProvider.Cbc + "MarkAttentionIndicator", delivery.DeliveryParty.MarkAttentionIndicator));

                    if (!String.IsNullOrEmpty(delivery.DeliveryParty.PartyName.Trim()))
                    {
                        DeliveryParty.Add(new XElement(NamespaceProvider.Cac + "PartyName",
                            new XElement(NamespaceProvider.Cbc + "Name", delivery.DeliveryParty.PartyName)));
                    }

                    if (delivery.DeliveryParty.PhysicalLocation != null)
                    {
                        XElement location = new XElement(NamespaceProvider.Cac + "PhysicalLocation");
                        XElement address = AddressXmlFill.FillAddress(delivery.DeliveryParty.PhysicalLocation, "Address");
                        if (address.HasElements)
                        {
                            location.Add(address);
                            DeliveryParty.Add(location);
                        }
                    }

                    if (delivery.DeliveryParty.PartyTaxScheme != null)
                    {
                        XElement nodeTaxScheme = PartyTaxSchemeXmlFill.FillPartyTaxScheme(delivery.DeliveryParty.PartyTaxScheme);
                        if (nodeTaxScheme.HasElements)
                            DeliveryParty.Add(nodeTaxScheme);
                    }

                    if (delivery.DeliveryParty.contact != null)
                    {
                        XElement nodeContact = DeliveryContactXmlFill.FillDeliveryContact(delivery.DeliveryParty.contact, "Contact");
                        if (nodeContact.HasElements)
                            DeliveryParty.Add(nodeContact);
                    }

                    NodoDelivery.Add(DeliveryParty);


                }

                if (delivery.Despatch != null)
                {
                    XElement NodeDespatch = new XElement(NamespaceProvider.Cac + "Despatch");
                    if (!String.IsNullOrEmpty(delivery.Despatch.ID.Trim()))
                        NodeDespatch.Add(new XElement(NamespaceProvider.Cbc + "ID", delivery.Despatch.ID.Trim(),
                            new XAttribute("schemeName", delivery.Despatch.SchemeName)));

                    if (delivery.Despatch.RequestedDespatchDate.HasValue)
                        NodeDespatch.Add(new XElement(NamespaceProvider.Cbc + "RequestedDespatchDate", delivery.Despatch.RequestedDespatchDate.Value.ToString("yyyy-MM-dd")));

                    if (delivery.Despatch.RequestedDespatchTime.HasValue)
                        NodeDespatch.Add(new XElement(NamespaceProvider.Cbc + "RequestedDespatchTime", delivery.Despatch.RequestedDespatchTime.Value.ToString("hh:mm:ss")));

                    if (delivery.Despatch.EstimatedDespatchDate.HasValue)
                        NodeDespatch.Add(new XElement(NamespaceProvider.Cbc + "EstimatedDespatchDate", delivery.Despatch.EstimatedDespatchDate.Value.ToString("yyyy-MM-dd")));

                    if (delivery.Despatch.EstimatedDespatchTime.HasValue)
                        NodeDespatch.Add(new XElement(NamespaceProvider.Cbc + "EstimatedDespatchTime", delivery.Despatch.EstimatedDespatchTime.Value.ToString("hh:mm:ss")));

                    if (delivery.Despatch.ActualDespatchDate.HasValue)
                        NodeDespatch.Add(new XElement(NamespaceProvider.Cbc + "ActualDespatchDate", delivery.Despatch.ActualDespatchDate.Value.ToString("yyyy-MM-dd")));

                    if (delivery.Despatch.ActualDespatchTime.HasValue)
                        NodeDespatch.Add(new XElement(NamespaceProvider.Cbc + "ActualDespatchTime", delivery.Despatch.ActualDespatchTime.Value.ToString("hh:mm:ss")));

                    if (delivery.Despatch.DespatchAddress != null)
                    {
                        XElement depatchAdd = AddressXmlFill.FillAddress(delivery.Despatch.DespatchAddress, "DespatchAddress");
                        if (depatchAdd != null)
                            if (depatchAdd.HasElements)
                                NodeDespatch.Add(depatchAdd);
                    }
                    if (delivery.Despatch.DespatchParty != null)
                    {
                        //XElement NodeDepatchparty = FillParty(de, delivery.Despatch.DespatchParty, "DespatchParty"); //OJO cambiar por DE
                        XElement NodeDepatchparty = PartyXmlFill.FillParty(delivery.Despatch.DespatchParty, "DespatchParty"); //OJO cambiar por DE
                        if (NodeDepatchparty.HasElements)
                            NodeDespatch.Add(NodeDepatchparty);
                    }

                    if (NodeDespatch != null)
                    {
                        if (NodeDespatch.HasElements)
                        {
                            NodoDelivery.Add(NodeDespatch);
                        }
                    }


                }

                if (NodoDelivery.HasElements)
                {
                    return NodoDelivery;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

    }
}
