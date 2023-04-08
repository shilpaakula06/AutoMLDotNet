﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace AutoMLDotNet
{
    public partial class MLModel1
    {
        /// <summary>
        /// model input class for MLModel1.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"UNIXTime")]
            public float UNIXTime { get; set; }

            [ColumnName(@"Data")]
            public string Data { get; set; }

            [ColumnName(@"Time")]
            public string Time { get; set; }

            [ColumnName(@"Radiation")]
            public float Radiation { get; set; }

            [ColumnName(@"Temperature")]
            public float Temperature { get; set; }

            [ColumnName(@"Pressure")]
            public float Pressure { get; set; }

            [ColumnName(@"Humidity")]
            public float Humidity { get; set; }

            [ColumnName(@"WindDirection(Degrees)")]
            public float WindDirection_Degrees_ { get; set; }

            [ColumnName(@"Speed")]
            public float Speed { get; set; }

            [ColumnName(@"TimeSunRise")]
            public string TimeSunRise { get; set; }

            [ColumnName(@"TimeSunSet")]
            public string TimeSunSet { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel1.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"UNIXTime")]
            public float UNIXTime { get; set; }

            [ColumnName(@"Data")]
            public float[] Data { get; set; }

            [ColumnName(@"Time")]
            public float[] Time { get; set; }

            [ColumnName(@"Radiation")]
            public uint Radiation { get; set; }

            [ColumnName(@"Temperature")]
            public float Temperature { get; set; }

            [ColumnName(@"Pressure")]
            public float Pressure { get; set; }

            [ColumnName(@"Humidity")]
            public float Humidity { get; set; }

            [ColumnName(@"WindDirection(Degrees)")]
            public float WindDirection_Degrees_ { get; set; }

            [ColumnName(@"Speed")]
            public float Speed { get; set; }

            [ColumnName(@"TimeSunRise")]
            public float[] TimeSunRise { get; set; }

            [ColumnName(@"TimeSunSet")]
            public float[] TimeSunSet { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public float PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float[] Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLModel1.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}