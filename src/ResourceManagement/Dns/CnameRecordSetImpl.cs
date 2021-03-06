// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using Microsoft.Azure.Management.Dns.Fluent.Models;
using System;

namespace Microsoft.Azure.Management.Dns.Fluent
{
    /// <summary>
    /// Implementation of CNameRecordSet.
    /// </summary>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LmRucy5pbXBsZW1lbnRhdGlvbi5DbmFtZVJlY29yZFNldEltcGw=
    internal partial class CNameRecordSetImpl :
        DnsRecordSetImpl,
        ICNameRecordSet
    {

        ///GENMHASH:7D787B3687385E18B312D5F6D6DA9444:AF11C8A7E2B299112E3CED7714F622A7
        protected override RecordSetInner PrepareForUpdate(RecordSetInner resource)
        {
            return resource;
        }

        ///GENMHASH:E5A5F4A2DE55AF67359951B8714E8E37:3F5F2CC7F3C4A3B943EC7C1953A9D2E5
        internal CNameRecordSetImpl(DnsZoneImpl parent, RecordSetInner innerModel) : base(parent, innerModel)
        {
        }

        ///GENMHASH:AEA8C8A92DBF6D46B8137727B5EEFACA:D5B3BC12D1EBABAB93ACF0C43C024873
        internal static CNameRecordSetImpl NewRecordSet(string name, DnsZoneImpl parent)
        {
            return new CNameRecordSetImpl(parent,
            new RecordSetInner
            {
                Name = name,
                Type = Enum.GetName(typeof(RecordType), Models.RecordType.CNAME),
                CnameRecord = new CnameRecord()
            });
        }

        ///GENMHASH:90659807B6B17ED9B2E619F2F74829BA:5F97BB0D1B58FFF4810D8B3F037EC111
        public string CanonicalName()
        {
            if (Inner.CnameRecord != null)
            {
                return Inner.CnameRecord.Cname;
            }
            return null;
        }
    }
}
