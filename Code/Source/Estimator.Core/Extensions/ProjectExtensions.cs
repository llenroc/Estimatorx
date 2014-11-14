﻿using System;
using System.Linq;

namespace Estimator.Core.Extensions
{
    public static class ProjectExtensions
    {
        /// <summary>
        /// Updates all the totals the specified <paramref name="project"/>.
        /// </summary>
        /// <param name="project">The project to total.</param>
        /// <returns></returns>
        public static Project UpdateTotals(this Project project)
        {
            var hoursPerWeek = (double)project.HoursPerWeek;

            foreach (var section in project.Sections)
            {
                UpdateSection(project, section);

                // update parent totals
                project.TotalTasks += section.TotalTasks;
                project.TotalHours += section.TotalHours;
            }

                // calculate weeks after children total
            project.TotalWeeks = project.TotalHours / hoursPerWeek;

            return project;
        }

        private static void UpdateSection(Project project, Section section)
        {
            foreach (var estimate in section.Estimates)
            {
                UpdateEstimate(project, estimate);

                // update parent totals
                section.TotalTasks += estimate.TotalTasks;
                section.TotalHours += estimate.TotalHours;
            }

            // calculate weeks after children total
            var hoursPerWeek = (double)project.HoursPerWeek;
            section.TotalWeeks = section.TotalHours / hoursPerWeek;
        }

        private static void UpdateEstimate(Project project, Estimate estimate)
        {
            byte verySimple = (estimate.VerySimple ?? 0);
            byte simple = (estimate.Simple ?? 0);
            byte medium = (estimate.Medium ?? 0);
            byte complex = (estimate.Complex ?? 0);
            byte veryComplex = (estimate.VeryComplex ?? 0);

            var factor = project.Factors.FirstOrDefault(f => f.Id == estimate.FactorId) ?? new Factor();

            estimate.TotalTasks = verySimple
                + simple
                + medium
                + complex
                + veryComplex;

            estimate.TotalHours = (verySimple * factor.VerySimple)
                + (simple * factor.Simple)
                + (medium * factor.Medium)
                + (complex * factor.Complex)
                + (veryComplex * factor.VeryComplex);
        }
    }
}
