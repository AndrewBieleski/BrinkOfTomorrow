using UnityEngine;

namespace Tools
{
	public class Easing
	{
		public static float Linear(float p)
		{
			return p;
		}

		public class Quadratic
		{
			public static float In(float p)
			{
				return p * p;
			}

			public static float Out(float p)
			{
				return p * (2f - p);
			}

			public static float InOut(float p)
			{
				if ((p *= 2f) < 1f) return 0.5f * p * p;
				return -0.5f * ((p -= 1f) * (p - 2f) - 1f);
			}
		}

		public class Cubic
		{
			public static float In(float p)
			{
				return p * p * p;
			}

			public static float Out(float p)
			{
				return 1f + ((p -= 1f) * p * p);
			}

			public static float InOut(float p)
			{
				if ((p *= 2f) < 1f) return 0.5f * p * p * p;
				return 0.5f * ((p -= 2f) * p * p + 2f);
			}
		}

		public class Quartic
		{
			public static float In(float p)
			{
				return p * p * p * p;
			}

			public static float Out(float p)
			{
				return 1f - (p -= 1f) * p * p * p;
			}

			public static float InOut(float p)
			{
				return (p *= 2f) < 1f ? 0.5f * p * p * p * p : -0.5f * ((p -= 2f) * p * p * p - 2f);
			}
		}

		public class Quintic
		{
			public static float In(float p)
			{
				return p * p * p * p * p;
			}

			public static float Out(float p)
			{
				return 1f + (p -= 1f) * p * p * p * p;
			}

			public static float InOut(float _k)
			{
				return (_k *= 2f) < 1f ? 0.5f * _k * _k * _k * _k * _k : 0.5f * ((_k -= 2f) * _k * _k * _k * _k + 2f);
			}
		}

		public class Sinusoidal
		{
			public static float In(float p)
			{
				return 1f - Mathf.Cos(p * Mathf.PI / 2f);
			}

			public static float Out(float p)
			{
				return Mathf.Sin(p * Mathf.PI / 2f);
			}

			public static float InOut(float p)
			{
				return 0.5f * (1f - Mathf.Cos(Mathf.PI * p));
			}
		}

		public class Exponential
		{
			public static float In(float p)
			{
				return Mathf.Approximately(p, 0f) ? 0f : Mathf.Pow(1024f, p - 1f);
			}

			public static float Out(float p)
			{
				return Mathf.Approximately(p, 1f) ? 1f : 1f - Mathf.Pow(2f, -10f * p);
			}

			public static float InOut(float p)
			{
				if (Mathf.Approximately(p, 0f))
				{
					return 0f;
				}

				if (Mathf.Approximately(p, 1f))
				{
					return 1f;
				}

				if ((p *= 2f) < 1f)
				{
					return 0.5f * Mathf.Pow(1024f, p - 1f);
				}
				return 0.5f * (-Mathf.Pow(2f, -10f * (p - 1f)) + 2f);
			}
		}

		public class Circular
		{
			public static float In(float p)
			{
				return 1f - Mathf.Sqrt(1f - p * p);
			}

			public static float Out(float p)
			{
				return Mathf.Sqrt(1f - (p -= 1f) * p);
			}

			public static float InOut(float p)
			{
				return (p *= 2f) < 1f ? -0.5f * (Mathf.Sqrt(1f - p * p) - 1) : 0.5f * (Mathf.Sqrt(1f - (p -= 2f) * p) + 1f);
			}
		}

		public class Elastic
		{
			public static float In(float p)
			{
				if (Mathf.Approximately(p, 0f))
				{
					return 0f;
				}

				if (Mathf.Approximately(p, 1f))
				{
					return 1f;
				}
				return -Mathf.Pow(2f, 10f * (p -= 1f)) * Mathf.Sin((p - 0.1f) * (2f * Mathf.PI) / 0.4f);
			}

			public static float Out(float p)
			{
				if (Mathf.Approximately(p, 0f))
				{
					return 0f;
				}

				if (Mathf.Approximately(p, 1f))
				{
					return 1f;
				}
				return Mathf.Pow(2f, -10f * p) * Mathf.Sin((p - 0.1f) * (2f * Mathf.PI) / 0.4f) + 1f;
			}

			public static float InOut(float p)
			{
				if ((p *= 2f) < 1f)
				{
					return -0.5f * Mathf.Pow(2f, 10f * (p -= 1f)) * Mathf.Sin((p - 0.1f) * (2f * Mathf.PI) / 0.4f);
				}
				return Mathf.Pow(2f, -10f * (p -= 1f)) * Mathf.Sin((p - 0.1f) * (2f * Mathf.PI) / 0.4f) * 0.5f + 1f;
			}
		}

		public class Back
		{
			private const float S = 1.70158f;
			private const float S2 = 2.5949095f;

			public static float In(float p)
			{
				return p * p * ((S + 1f) * p - S);
			}

			public static float Out(float p)
			{
				return (p -= 1f) * p * ((S + 1f) * p + S) + 1f;
			}

			public static float InOut(float p)
			{
				if ((p *= 2f) < 1f)
				{
					return 0.5f * (p * p * ((S2 + 1f) * p - S2));
				}

				return 0.5f * ((p -= 2f) * p * ((S2 + 1f) * p + S2) + 2f);
			}
		}

		public class Bounce
		{
			public static float In(float p)
			{
				return 1f - Out(1f - p);
			}

			public static float Out(float p)
			{
				if (p < 1f / 2.75f)
				{
					return 7.5625f * p * p;
				}

				if (p < 2f / 2.75f)
				{
					return 7.5625f * (p -= 1.5f / 2.75f) * p + 0.75f;
				}

				if (p < 2.5f / 2.75f)
				{
					return 7.5625f * (p -= 2.25f / 2.75f) * p + 0.9375f;
				}

				return 7.5625f * (p -= 2.625f / 2.75f) * p + 0.984375f;
			}

			public static float InOut(float p)
			{
				return p < 0.5f ? In(p * 2f) * 0.5f : Out(p * 2f - 1f) * 0.5f + 0.5f;
			}
		}
	}
}

