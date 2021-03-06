﻿using AutoMapper;
using OutcomesFirst.Models;
using OutcomesFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OutcomesFirst
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Referral, ReferralViewModel>();
            CreateMap<ReferralViewModel, Referral>();

            CreateMap<Submission, SubmissionIndexData>();
            CreateMap<SubmissionIndexData, Submission>();

            CreateMap<Submission, SubmissionViewModel>();
            CreateMap<SubmissionViewModel, Submission>();

            CreateMap<ArchiveReferral, ArchiveReferralViewModel>();
            CreateMap<ArchiveReferralViewModel, ArchiveReferral>();

            CreateMap<ArchiveReason, ArchiveReasonViewModel>();
            CreateMap<ArchiveReasonViewModel, ArchiveReason>();

            CreateMap<Gender, GenderViewModel>();
            CreateMap<GenderViewModel, Gender>();

            CreateMap<LocalAuthority, LocalAuthorityViewModel>();
            CreateMap<LocalAuthorityViewModel, LocalAuthority>();

            CreateMap<RegionalManager, RegionalManagerViewModel>();
            CreateMap<RegionalManagerViewModel, RegionalManager>();

            CreateMap<Region, RegionViewModel>();
            CreateMap<RegionViewModel, Region>();

            CreateMap<Status, StatusViewModel>();
            CreateMap<StatusViewModel, Status>();

            CreateMap<LeavingReason, LeavingReasonsViewModel>();
            CreateMap<LeavingReasonsViewModel, LeavingReason>();

            CreateMap<Placement, PlacementViewModel>();
            CreateMap<PlacementViewModel, Placement>();

            CreateMap<Service, ServiceViewModel>();
            CreateMap<ServiceViewModel, Service>();

            CreateMap<Submission, SubmissionViewModel>();
            CreateMap<SubmissionViewModel, Submission>();



        }

    }
}
