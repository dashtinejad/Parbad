// Copyright (c) Parbad. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC License, Version 3.0. See License.txt in the project root for license information.

using System;
using Parbad.Storage.Abstractions;
using Parbad.Storage.EntityFrameworkCore.Domain.Payments;

namespace Parbad.Storage.EntityFrameworkCore.Domain.Transactions
{
    public class TransactionEntity : Transaction
    {
        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public PaymentEntity Payment { get; set; }
    }
}
