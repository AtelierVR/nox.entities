using System;
using UnityEngine;

namespace Nox.CCK.Entities {
	/// <summary>
	/// Rig slot of an entity part: where a part sits on the entity skeleton.
	/// <para>
	/// The values are the wire format shared with the relay: never reorder them.
	/// </para>
	/// </summary>
	public enum EntityRig : ushort {
		// position on floor
		Base = 0,

		// postions of body
		Hips  = 1,
		Spine = 2,
		Chest = 3,
		Neck  = 4,
		Head  = 5,

		// positions of arms
		LeftShoulder  = 6,
		LeftArm       = 7,
		LeftForearm   = 8,
		LeftHand      = 9,
		RightShoulder = 10,
		RightArm      = 11,
		RightForearm  = 12,
		RightHand     = 13,

		// positions of legs
		LeftUpperLeg  = 14,
		LeftLowerLeg  = 15,
		LeftFoot      = 16,
		LeftToes      = 17,
		RightUpperLeg = 18,
		RightLowerLeg = 19,
		RightFoot     = 20,
		RightToes     = 21,

		// positions of fingers
		LeftThumb       = 22,
		LeftIndex       = 23,
		LeftMiddle      = 24,
		LeftRing        = 25,
		LeftPinky       = 26,
		LeftThumbTip    = 27,
		LeftIndexTip    = 28,
		LeftMiddleTip   = 29,
		LeftRingTip     = 30,
		LeftPinkyTip    = 31,
		LeftThumbNail   = 32,
		LeftIndexNail   = 33,
		LeftMiddleNail  = 34,
		LeftRingNail    = 35,
		LeftPinkyNail   = 36,
		RightThumb      = 37,
		RightIndex      = 38,
		RightMiddle     = 39,
		RightRing       = 40,
		RightPinky      = 41,
		RightThumbTip   = 42,
		RightIndexTip   = 43,
		RightMiddleTip  = 44,
		RightRingTip    = 45,
		RightPinkyTip   = 46,
		RightThumbNail  = 47,
		RightIndexNail  = 48,
		RightMiddleNail = 49,
		RightRingNail   = 50,
		RightPinkyNail  = 51,

		// positions of head parts
		RightEye = 52,
		LeftEye  = 53,

		None = ushort.MaxValue
	}

	public static class EntityRigExtension {
		public static HumanBodyBones ToHumanBodyBones(this EntityRig rig)
			=> rig switch {
				EntityRig.Hips            => HumanBodyBones.Hips,
				EntityRig.Spine           => HumanBodyBones.Spine,
				EntityRig.Chest           => HumanBodyBones.Chest,
				EntityRig.Neck            => HumanBodyBones.Neck,
				EntityRig.Head            => HumanBodyBones.Head,
				EntityRig.LeftShoulder    => HumanBodyBones.LeftShoulder,
				EntityRig.LeftArm         => HumanBodyBones.LeftUpperArm,
				EntityRig.LeftForearm     => HumanBodyBones.LeftLowerArm,
				EntityRig.LeftHand        => HumanBodyBones.LeftHand,
				EntityRig.RightShoulder   => HumanBodyBones.RightShoulder,
				EntityRig.RightArm        => HumanBodyBones.RightUpperArm,
				EntityRig.RightForearm    => HumanBodyBones.RightLowerArm,
				EntityRig.RightHand       => HumanBodyBones.RightHand,
				EntityRig.LeftUpperLeg    => HumanBodyBones.LeftUpperLeg,
				EntityRig.LeftLowerLeg    => HumanBodyBones.LeftLowerLeg,
				EntityRig.LeftFoot        => HumanBodyBones.LeftFoot,
				EntityRig.LeftToes        => HumanBodyBones.LeftToes,
				EntityRig.RightUpperLeg   => HumanBodyBones.RightUpperLeg,
				EntityRig.RightLowerLeg   => HumanBodyBones.RightLowerLeg,
				EntityRig.RightFoot       => HumanBodyBones.RightFoot,
				EntityRig.RightToes       => HumanBodyBones.RightToes,
				EntityRig.LeftThumb       => HumanBodyBones.LeftThumbProximal,
				EntityRig.LeftIndex       => HumanBodyBones.LeftIndexProximal,
				EntityRig.LeftMiddle      => HumanBodyBones.LeftMiddleProximal,
				EntityRig.LeftRing        => HumanBodyBones.LeftRingProximal,
				EntityRig.LeftPinky       => HumanBodyBones.LeftLittleProximal,
				EntityRig.LeftThumbTip    => HumanBodyBones.LeftThumbDistal,
				EntityRig.LeftIndexTip    => HumanBodyBones.LeftIndexDistal,
				EntityRig.LeftMiddleTip   => HumanBodyBones.LeftMiddleDistal,
				EntityRig.LeftRingTip     => HumanBodyBones.LeftRingDistal,
				EntityRig.LeftPinkyTip    => HumanBodyBones.LeftLittleDistal,
				EntityRig.LeftThumbNail   => HumanBodyBones.LeftThumbIntermediate,
				EntityRig.LeftIndexNail   => HumanBodyBones.LeftIndexIntermediate,
				EntityRig.LeftMiddleNail  => HumanBodyBones.LeftMiddleIntermediate,
				EntityRig.LeftRingNail    => HumanBodyBones.LeftRingIntermediate,
				EntityRig.LeftPinkyNail   => HumanBodyBones.LeftLittleIntermediate,
				EntityRig.RightThumb      => HumanBodyBones.RightThumbProximal,
				EntityRig.RightIndex      => HumanBodyBones.RightIndexProximal,
				EntityRig.RightMiddle     => HumanBodyBones.RightMiddleProximal,
				EntityRig.RightRing       => HumanBodyBones.RightRingProximal,
				EntityRig.RightPinky      => HumanBodyBones.RightLittleProximal,
				EntityRig.RightThumbTip   => HumanBodyBones.RightThumbDistal,
				EntityRig.RightIndexTip   => HumanBodyBones.RightIndexDistal,
				EntityRig.RightMiddleTip  => HumanBodyBones.RightMiddleDistal,
				EntityRig.RightRingTip    => HumanBodyBones.RightRingDistal,
				EntityRig.RightPinkyTip   => HumanBodyBones.RightLittleDistal,
				EntityRig.RightThumbNail  => HumanBodyBones.RightThumbIntermediate,
				EntityRig.RightIndexNail  => HumanBodyBones.RightIndexIntermediate,
				EntityRig.RightMiddleNail => HumanBodyBones.RightMiddleIntermediate,
				EntityRig.RightRingNail   => HumanBodyBones.RightRingIntermediate,
				EntityRig.RightPinkyNail  => HumanBodyBones.RightLittleIntermediate,
				EntityRig.RightEye        => HumanBodyBones.RightEye,
				EntityRig.LeftEye         => HumanBodyBones.LeftEye,
				_                         => HumanBodyBones.LastBone
			};

		public static EntityRig ToEntityRig(this HumanBodyBones bones)
			=> bones switch {
				HumanBodyBones.Hips                    => EntityRig.Hips,
				HumanBodyBones.Spine                   => EntityRig.Spine,
				HumanBodyBones.Chest                   => EntityRig.Chest,
				HumanBodyBones.Neck                    => EntityRig.Neck,
				HumanBodyBones.Head                    => EntityRig.Head,
				HumanBodyBones.LeftShoulder            => EntityRig.LeftShoulder,
				HumanBodyBones.LeftUpperArm            => EntityRig.LeftArm,
				HumanBodyBones.LeftLowerArm            => EntityRig.LeftForearm,
				HumanBodyBones.LeftHand                => EntityRig.LeftHand,
				HumanBodyBones.RightShoulder           => EntityRig.RightShoulder,
				HumanBodyBones.RightUpperArm           => EntityRig.RightArm,
				HumanBodyBones.RightLowerArm           => EntityRig.RightForearm,
				HumanBodyBones.RightHand               => EntityRig.RightHand,
				HumanBodyBones.LeftUpperLeg            => EntityRig.LeftUpperLeg,
				HumanBodyBones.LeftLowerLeg            => EntityRig.LeftLowerLeg,
				HumanBodyBones.LeftFoot                => EntityRig.LeftFoot,
				HumanBodyBones.LeftToes                => EntityRig.LeftToes,
				HumanBodyBones.RightUpperLeg           => EntityRig.RightUpperLeg,
				HumanBodyBones.RightLowerLeg           => EntityRig.RightLowerLeg,
				HumanBodyBones.RightFoot               => EntityRig.RightFoot,
				HumanBodyBones.RightToes               => EntityRig.RightToes,
				HumanBodyBones.LeftThumbProximal       => EntityRig.LeftThumb,
				HumanBodyBones.LeftIndexProximal       => EntityRig.LeftIndex,
				HumanBodyBones.LeftMiddleProximal      => EntityRig.LeftMiddle,
				HumanBodyBones.LeftRingProximal        => EntityRig.LeftRing,
				HumanBodyBones.LeftLittleProximal      => EntityRig.LeftPinky,
				HumanBodyBones.LeftThumbDistal         => EntityRig.LeftThumbTip,
				HumanBodyBones.LeftIndexDistal         => EntityRig.LeftIndexTip,
				HumanBodyBones.LeftMiddleDistal        => EntityRig.LeftMiddleTip,
				HumanBodyBones.LeftRingDistal          => EntityRig.LeftRingTip,
				HumanBodyBones.LeftLittleDistal        => EntityRig.LeftPinkyTip,
				HumanBodyBones.LeftThumbIntermediate   => EntityRig.LeftThumbNail,
				HumanBodyBones.LeftIndexIntermediate   => EntityRig.LeftIndexNail,
				HumanBodyBones.LeftMiddleIntermediate  => EntityRig.LeftMiddleNail,
				HumanBodyBones.LeftRingIntermediate    => EntityRig.LeftRingNail,
				HumanBodyBones.LeftLittleIntermediate  => EntityRig.LeftPinkyNail,
				HumanBodyBones.RightThumbProximal      => EntityRig.RightThumb,
				HumanBodyBones.RightIndexProximal      => EntityRig.RightIndex,
				HumanBodyBones.RightMiddleProximal     => EntityRig.RightMiddle,
				HumanBodyBones.RightRingProximal       => EntityRig.RightRing,
				HumanBodyBones.RightLittleProximal     => EntityRig.RightPinky,
				HumanBodyBones.RightThumbDistal        => EntityRig.RightThumbTip,
				HumanBodyBones.RightIndexDistal        => EntityRig.RightIndexTip,
				HumanBodyBones.RightMiddleDistal       => EntityRig.RightMiddleTip,
				HumanBodyBones.RightRingDistal         => EntityRig.RightRingTip,
				HumanBodyBones.RightLittleDistal       => EntityRig.RightPinkyTip,
				HumanBodyBones.RightThumbIntermediate  => EntityRig.RightThumbNail,
				HumanBodyBones.RightIndexIntermediate  => EntityRig.RightIndexNail,
				HumanBodyBones.RightMiddleIntermediate => EntityRig.RightMiddleNail,
				HumanBodyBones.RightRingIntermediate   => EntityRig.RightRingNail,
				HumanBodyBones.RightLittleIntermediate => EntityRig.RightPinkyNail,
				HumanBodyBones.RightEye                => EntityRig.RightEye,
				HumanBodyBones.LeftEye                 => EntityRig.LeftEye,
				_                                      => EntityRig.None
			};

		public static ushort ToIndex(this EntityRig rig)
			=> (ushort)rig;
		
		public static ushort ToIndex(this HumanBodyBones bones)
			=> bones.ToEntityRig().ToIndex();

		/// <summary>Rig part of a part index, or <see cref="EntityRig.None"/> when the index is unknown.</summary>
		public static EntityRig ToEntityRig(this ushort index)
			=> Enum.IsDefined(typeof(EntityRig), index)
				? (EntityRig)index
				: EntityRig.None;

		/// <summary>
		/// Humanoid bone of a rig part index
		/// (goes through <see cref="ToEntityRig(ushort)"/>: the two enums do not share their numbering).
		/// </summary>
		public static HumanBodyBones ToHumanBodyBones(this ushort index)
			=> index.ToEntityRig().ToHumanBodyBones();
	}
}