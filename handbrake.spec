%global	_cpus		1

Summary:        HandBrake
Name:           handbrake
Version:        0.10.0.20150122
Release:        2%{?dist}
Group:          System Environment/Base
License:        GPLv2+
URL:            http://handbrake.rf
Source0:        http://handbrake.fr/downloads/%{name}-%{version}.tar.gz

BuildRequires:  autoconf automake cmake git libtool m4 pkgconfig subversion
BuildRequires:  perl-Digest-MD5 wget
BuildRequires:  yasm zlib-devel bzip2-devel
BuildRequires:	libogg-devel libtheora-devel libvorbis-devel libsamplerate-devel libxml2-devel fribidi-devel
BuildRequires:	freetype-devel fontconfig-devel libass-devel lame-devel x264-devel
BuildRequires:	dbus-glib-devel libgudev1-devel webkitgtk-devel libnotify-devel
BuildRequires:	gstreamer-devel gstreamer-plugins-base-devel

%description
Handbrake

%prep
%setup -q -a0

%build
#./configure --enable-opencl --disable-gtk --enable-local-yasm --launch --launch-jobs=%{_cpus} --force
#./configure --disable-gtk --enable-local-yasm --launch --launch-jobs=%{_cpus} --force
#./configure --disable-gtk --launch --launch-jobs=%{_cpus} --force
%configure --disable-gtk --launch --launch-jobs=%{_cpus} --force
#%configure
#make %{?_smp_mflags}

%install
#make DESTDIR=%{buildroot} install
cp -a build/HandbrakeCLI %{buildroot}/usr/bin/HandbrakeCLI

%post

%preun

%postun

%files
%doc AUTHORS ChangeLog COPYING NEWS README
%{_bindir}/*
#%attr(0644,root,root)   %{_unitdir}/rngd.service

%changelog
* Thu Jan 22 2015 Michael J. Ayers <ayersm@gmail.com> 0.10.0.20150122-2
- Fixed configure arguments (ayersm@gmail.com)

* Thu Jan 22 2015 Michael J. Ayers <ayersm@gmail.com> 0.10.0.20150122-1
- new package built with tito

* Thu Jan 22 2015 Michael J. Ayers <ayersm@gmail.com> - 0.10.0.20150122-0
- Initial upstream build.
