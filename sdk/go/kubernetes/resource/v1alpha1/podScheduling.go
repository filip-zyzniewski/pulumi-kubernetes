// Code generated by pulumigen DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1alpha1

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// PodScheduling objects hold information that is needed to schedule a Pod with ResourceClaims that use "WaitForFirstConsumer" allocation mode.
//
// This is an alpha type and requires enabling the DynamicResourceAllocation feature gate.
type PodScheduling struct {
	pulumi.CustomResourceState

	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrOutput `pulumi:"apiVersion"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Standard object metadata
	Metadata metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// Spec describes where resources for the Pod are needed.
	Spec PodSchedulingSpecOutput `pulumi:"spec"`
	// Status describes where resources for the Pod can be allocated.
	Status PodSchedulingStatusPtrOutput `pulumi:"status"`
}

// NewPodScheduling registers a new resource with the given unique name, arguments, and options.
func NewPodScheduling(ctx *pulumi.Context,
	name string, args *PodSchedulingArgs, opts ...pulumi.ResourceOption) (*PodScheduling, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Spec == nil {
		return nil, errors.New("invalid value for required argument 'Spec'")
	}
	args.ApiVersion = pulumi.StringPtr("resource.k8s.io/v1alpha1")
	args.Kind = pulumi.StringPtr("PodScheduling")
	var resource PodScheduling
	err := ctx.RegisterResource("kubernetes:resource.k8s.io/v1alpha1:PodScheduling", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPodScheduling gets an existing PodScheduling resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPodScheduling(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PodSchedulingState, opts ...pulumi.ResourceOption) (*PodScheduling, error) {
	var resource PodScheduling
	err := ctx.ReadResource("kubernetes:resource.k8s.io/v1alpha1:PodScheduling", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PodScheduling resources.
type podSchedulingState struct {
}

type PodSchedulingState struct {
}

func (PodSchedulingState) ElementType() reflect.Type {
	return reflect.TypeOf((*podSchedulingState)(nil)).Elem()
}

type podSchedulingArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion *string `pulumi:"apiVersion"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind *string `pulumi:"kind"`
	// Standard object metadata
	Metadata *metav1.ObjectMeta `pulumi:"metadata"`
	// Spec describes where resources for the Pod are needed.
	Spec PodSchedulingSpec `pulumi:"spec"`
}

// The set of arguments for constructing a PodScheduling resource.
type PodSchedulingArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrInput
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind pulumi.StringPtrInput
	// Standard object metadata
	Metadata metav1.ObjectMetaPtrInput
	// Spec describes where resources for the Pod are needed.
	Spec PodSchedulingSpecInput
}

func (PodSchedulingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*podSchedulingArgs)(nil)).Elem()
}

type PodSchedulingInput interface {
	pulumi.Input

	ToPodSchedulingOutput() PodSchedulingOutput
	ToPodSchedulingOutputWithContext(ctx context.Context) PodSchedulingOutput
}

func (*PodScheduling) ElementType() reflect.Type {
	return reflect.TypeOf((**PodScheduling)(nil)).Elem()
}

func (i *PodScheduling) ToPodSchedulingOutput() PodSchedulingOutput {
	return i.ToPodSchedulingOutputWithContext(context.Background())
}

func (i *PodScheduling) ToPodSchedulingOutputWithContext(ctx context.Context) PodSchedulingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PodSchedulingOutput)
}

// PodSchedulingArrayInput is an input type that accepts PodSchedulingArray and PodSchedulingArrayOutput values.
// You can construct a concrete instance of `PodSchedulingArrayInput` via:
//
//	PodSchedulingArray{ PodSchedulingArgs{...} }
type PodSchedulingArrayInput interface {
	pulumi.Input

	ToPodSchedulingArrayOutput() PodSchedulingArrayOutput
	ToPodSchedulingArrayOutputWithContext(context.Context) PodSchedulingArrayOutput
}

type PodSchedulingArray []PodSchedulingInput

func (PodSchedulingArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PodScheduling)(nil)).Elem()
}

func (i PodSchedulingArray) ToPodSchedulingArrayOutput() PodSchedulingArrayOutput {
	return i.ToPodSchedulingArrayOutputWithContext(context.Background())
}

func (i PodSchedulingArray) ToPodSchedulingArrayOutputWithContext(ctx context.Context) PodSchedulingArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PodSchedulingArrayOutput)
}

// PodSchedulingMapInput is an input type that accepts PodSchedulingMap and PodSchedulingMapOutput values.
// You can construct a concrete instance of `PodSchedulingMapInput` via:
//
//	PodSchedulingMap{ "key": PodSchedulingArgs{...} }
type PodSchedulingMapInput interface {
	pulumi.Input

	ToPodSchedulingMapOutput() PodSchedulingMapOutput
	ToPodSchedulingMapOutputWithContext(context.Context) PodSchedulingMapOutput
}

type PodSchedulingMap map[string]PodSchedulingInput

func (PodSchedulingMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PodScheduling)(nil)).Elem()
}

func (i PodSchedulingMap) ToPodSchedulingMapOutput() PodSchedulingMapOutput {
	return i.ToPodSchedulingMapOutputWithContext(context.Background())
}

func (i PodSchedulingMap) ToPodSchedulingMapOutputWithContext(ctx context.Context) PodSchedulingMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PodSchedulingMapOutput)
}

type PodSchedulingOutput struct{ *pulumi.OutputState }

func (PodSchedulingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PodScheduling)(nil)).Elem()
}

func (o PodSchedulingOutput) ToPodSchedulingOutput() PodSchedulingOutput {
	return o
}

func (o PodSchedulingOutput) ToPodSchedulingOutputWithContext(ctx context.Context) PodSchedulingOutput {
	return o
}

// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
func (o PodSchedulingOutput) ApiVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PodScheduling) pulumi.StringPtrOutput { return v.ApiVersion }).(pulumi.StringPtrOutput)
}

// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
func (o PodSchedulingOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PodScheduling) pulumi.StringPtrOutput { return v.Kind }).(pulumi.StringPtrOutput)
}

// Standard object metadata
func (o PodSchedulingOutput) Metadata() metav1.ObjectMetaPtrOutput {
	return o.ApplyT(func(v *PodScheduling) metav1.ObjectMetaPtrOutput { return v.Metadata }).(metav1.ObjectMetaPtrOutput)
}

// Spec describes where resources for the Pod are needed.
func (o PodSchedulingOutput) Spec() PodSchedulingSpecOutput {
	return o.ApplyT(func(v *PodScheduling) PodSchedulingSpecOutput { return v.Spec }).(PodSchedulingSpecOutput)
}

// Status describes where resources for the Pod can be allocated.
func (o PodSchedulingOutput) Status() PodSchedulingStatusPtrOutput {
	return o.ApplyT(func(v *PodScheduling) PodSchedulingStatusPtrOutput { return v.Status }).(PodSchedulingStatusPtrOutput)
}

type PodSchedulingArrayOutput struct{ *pulumi.OutputState }

func (PodSchedulingArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PodScheduling)(nil)).Elem()
}

func (o PodSchedulingArrayOutput) ToPodSchedulingArrayOutput() PodSchedulingArrayOutput {
	return o
}

func (o PodSchedulingArrayOutput) ToPodSchedulingArrayOutputWithContext(ctx context.Context) PodSchedulingArrayOutput {
	return o
}

func (o PodSchedulingArrayOutput) Index(i pulumi.IntInput) PodSchedulingOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *PodScheduling {
		return vs[0].([]*PodScheduling)[vs[1].(int)]
	}).(PodSchedulingOutput)
}

type PodSchedulingMapOutput struct{ *pulumi.OutputState }

func (PodSchedulingMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PodScheduling)(nil)).Elem()
}

func (o PodSchedulingMapOutput) ToPodSchedulingMapOutput() PodSchedulingMapOutput {
	return o
}

func (o PodSchedulingMapOutput) ToPodSchedulingMapOutputWithContext(ctx context.Context) PodSchedulingMapOutput {
	return o
}

func (o PodSchedulingMapOutput) MapIndex(k pulumi.StringInput) PodSchedulingOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *PodScheduling {
		return vs[0].(map[string]*PodScheduling)[vs[1].(string)]
	}).(PodSchedulingOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PodSchedulingInput)(nil)).Elem(), &PodScheduling{})
	pulumi.RegisterInputType(reflect.TypeOf((*PodSchedulingArrayInput)(nil)).Elem(), PodSchedulingArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*PodSchedulingMapInput)(nil)).Elem(), PodSchedulingMap{})
	pulumi.RegisterOutputType(PodSchedulingOutput{})
	pulumi.RegisterOutputType(PodSchedulingArrayOutput{})
	pulumi.RegisterOutputType(PodSchedulingMapOutput{})
}
